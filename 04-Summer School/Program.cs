using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Summer_School
{
    class Program
    {
        static string[] Students = new string[15];

        static void Main(string[] args)

        {        //1. Enroll a student
                 //2. Unenroll a student
                 //3. Print out the list of enrolled students
                 //4. Exit

            int choice = Convert.ToInt32(Console.ReadLine());
            while (true)
            {

                if (choice == 1)
                {
                    Enrollment();
                }
                else if (choice == 2)
                {

                }
                else if (choice == 3)
                {
                    
                }
                else if (choice == 4_)
               {

                }
            
        }    

        private static void Enrollment()
        {
            string student;
            student = Console.ReadLine();
            for (int i = 0, i < 15; i++)
            {
                if (Students[i] == null)
                {
                    Students[i] = student;
                    break;
                }
            }
           
            


        }
    }
}
