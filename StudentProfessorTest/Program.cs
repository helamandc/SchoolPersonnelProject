using SchoolPersonnelProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonClass myPersonClass = new PersonClass();
            myPersonClass.Greet();
            StudentClass myStudentClass = new StudentClass();
            myStudentClass.Greet();
            myStudentClass.SetAge(21);
            myStudentClass.ShowAge();
            myStudentClass.Study();
            TeacherClass myTeacherClass = new TeacherClass();
            myTeacherClass.Greet();
            myPersonClass.SetAge(21);
            myTeacherClass.Explain();
            Console.ReadLine();
        }
    }
}
