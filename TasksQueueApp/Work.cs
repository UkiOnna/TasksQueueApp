using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksQueueApp
{
   public class Work
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Status")]
        public int StatusId { get; set; }
        public Status Status { get; set; }
        [ForeignKey("Delievery")]
        public int DelieveryId { get; set; }
        public Delievery Delievery { get; set; }
        public int TaskId { get; set; }
    }
}
