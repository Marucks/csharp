using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person (string nameParam, string surnameParam)
        {
            Name = nameParam;
            Surname = surnameParam;
        }
        public void WriteBack()
        {

        }
    }
}
