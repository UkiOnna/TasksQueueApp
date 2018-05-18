namespace TasksQueueApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DelieveryContext : DbContext
    {
        // Контекст настроен для использования строки подключения "DelieveryContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "TasksQueueApp.DelieveryContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DelieveryContext" 
        // в файле конфигурации приложения.
        public DelieveryContext()
            : base("name=DelieveryContext")
        {
        }

        public DbSet<Delievery> Deliveries { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Status> Statuses { get; set; }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}