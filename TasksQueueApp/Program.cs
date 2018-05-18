using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksQueueApp
{
    class Program
    {
        static List<Status> statuses = new List<Status>();
        static List<Work> works = new List<Work>();
        static List<Delievery> deliveries = new List<Delievery>();
        static void Main(string[] args)
        {
            //using(var context =new DelieveryContext())
            //{ 
            //    Status stat = new Status { Id = 1, Name = "Новый" };
            //    Status statu = new Status { Id = 2, Name = "Работающий" };
            //    Status status = new Status { Id = 4, Name = "Закончен" };
            ////    context.Statuses.Add(stat);
            ////    context.Statuses.Add(statu);
            //    context.Statuses.Add(status);
            //    context.SaveChanges();
            //}


            Task firstSecond = new Task(new Action(Working));
            Task taskSecond = new Task(new Action(Working));
            Task taskThird = new Task(new Action(Working));
            Task taskFourth = new Task(new Action(Working));
            Task taskFifth = new Task(new Action(Working));
            while(true)
            {
                using (var context = new DelieveryContext())
                {
                    statuses = context.Statuses.ToList();
                    works = context.Works.ToList();
                    deliveries = context.Deliveries.ToList();
                    for(int i = 0; i < deliveries.Count; i++)
                    {
                        if (deliveries[i].CreationDate.Second >= deliveries[i].CreationDate.Second + 10)
                        {
                           for(int j = 0; j < works.Count; j++)
                            {
                                if (works[j].DelieveryId == deliveries[i].Id)
                                {
                                    works[j].StatusId = 3;
                                }
                            }
                        }
                    }

                    for(int i = 0; i < works.Count; i++)
                    {
                        if (works[i].StatusId == 1)
                        {
                           if( works.Where(work => work.TaskId == taskFirst.Id) == null)
                            {
                                taskFirst.Start();
                            }
                            if (works.Where(work => work.TaskId == taskFirst.Id) == null)
                            {
                                taskFirst.Start();
                            }
                        }
                    }
                }
            }

        }

        private static void Working(Work _work)
        {

        }

        private static void CreateDelievery()
        {
            using (var context = new DelieveryContext())
            {
                Delievery del = new Delievery
                {
                    CreationDate = DateTime.Now,
                    From = "Les",
                    To = "Gorod"
                };
                context.Deliveries.Add(del);

                Work task = new Work { Delievery = del, StatusId = 1, DelieveryId = del.Id, TaskId = 0 };
                context.Works.Add(task);
            }
        }

    }
}
