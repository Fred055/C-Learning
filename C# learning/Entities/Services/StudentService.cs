
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__learning.Entities.Services
{
    internal class StudentService
    {
        Student[] studentArray = { };

        void Yarat()
        {
            Console.WriteLine("Pls add student name:");
            Student student = new Student();
            student.Name = Console.ReadLine();

            Array.Resize(ref studentArray, studentArray.Length + 1);
            studentArray[studentArray.Length - 1] = student;
        }



            void TelebeleriGoster()
            {
                Console.WriteLine("Student List");

                foreach (var student in studentArray)
                {
                    Console.WriteLine(student.Name);
                }
            }
        

    }
}
