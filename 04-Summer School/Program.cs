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

        {       //1. Enroll a student
                //2. Unenroll a student
                //3. Print out the list of enrolled students
                //4. Exit



            while (true)
            {

                Console.WriteLine("Main Menu -- Enter a choice\n \n");
                Console.WriteLine("1. Enrollment\n");
                Console.WriteLine("2. Unenrollment\n");
                Console.WriteLine("3. Print \n");
                Console.WriteLine("4. Exit \n");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Enrollment();

                }
                else if (choice == 2)
                {
                    Unenrollment();

                }
                else if (choice == 3)
                {
                    Print();
                }
                else if (choice == 4)
                {
                    Exit();

                }

            }
        }
        private static void Exit()
        {

        }

        private static void Print()
        {

            Console.WriteLine(Students);
        }


        private static void Unenrollment()
        {

            Print();
            //get number from user. 
            //take number, correlate to index, remove that student

            Console.WriteLine("Enter number of student to remove");
            int studentNumber = Convert.ToInt32(Console.ReadLine());
            studentNumber = studentNumber - 1;


            Console.WriteLine("Students " + studentNumber + "has been unenrolled.");

            Students[studentNumber] = null;

        }



        private static int Enrollment()
        {


            string student = Console.ReadLine();
            for (int i = 0; i < 15; i++)
                Console.WriteLine("Enter name of student to enroll");
            {
                if (student.ToLower() == "voltemort")
                {
                    Console.WriteLine("RED ALERT!!! HE WHO MUST NOT BE NAMED!!!");
                }
                else

                    return i;
                }
           
       }
    }
}

