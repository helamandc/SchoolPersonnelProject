using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPersonnelProject
{
    public class StudentClass: PersonClass
    {

        public void Study()
        {
            Console.WriteLine("I'm studying.");
        }

        public void ShowAge()
        {
            PersonClass personClass = new PersonClass();
            Console.WriteLine($"My age is {personClass.personAge} years old.");
        }

    }
}
