using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_objekty
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public char Gender { get; set; }


        public bool IsAdult()
        {
            if (Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddName(string surname)
        {
            Name += surname;
        }

        public string GetAll()
        {
            return $"Name: {Name}\n Age: {Age}\n Adress {Adress}\n Gender {Gender};";
        }


    }
}
