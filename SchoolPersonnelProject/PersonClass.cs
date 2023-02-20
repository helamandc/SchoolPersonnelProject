using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPersonnelProject
{
    public class PersonClass
    {
        public int personAge;
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int age)
        {
            personAge = age;
        }

    }
}
