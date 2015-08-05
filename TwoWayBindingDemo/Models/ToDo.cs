using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwoWayBindingDemo.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Todo { get; set; }
        public bool IsComplete { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime CompletionDate { get; set; } 
    }
}