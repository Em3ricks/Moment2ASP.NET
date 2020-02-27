using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moment2.Models
{
    public class Person
    {

        // Tom Konstruktor
        public Person () { }

        public Person(int id, string name)
        {
            this.Id = id;
            this.Namn = name;
        }

        // Publika egenskaper
        public int Id { get; set; }
        public string Namn { get; set; }
    }

    public class ViewModeln
    {
        public IEnumerable<Person> PersonDetaljLista { get; set; }
    }
}
