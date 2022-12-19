using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method___Class_practices
{
    internal class Person
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public bool Ismarried { get; set; }

        public Person(string name, string surname, int age, bool ismarried)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Ismarried = ismarried;
        }

    }
}
