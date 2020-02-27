using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moment2.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Item()
        {
            Id = 1;
            Name = "Test av klass"; 
        }
    }
}
