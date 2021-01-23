using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManage.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public string name { get; set; }
        public DateTime deadline { get; set; }

    }
}
