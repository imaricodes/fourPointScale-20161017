using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourPointScale_20161017
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directions Write a program that calculates a student’s GPA on a 4.0 scale


            ////Failed attempt below (thinking of a to take user input)
                    //Console.WriteLine("Enter percentage for first class:");
                    //string input1 = Console.ReadLine();
                    //double grade1 = Convert.ToDouble(input1);

                    //Console.WriteLine("Enter percentage for next class. Type done if finished:");
                    //string input2 = Console.ReadLine();
                    //double grade2 = Convert.ToDouble(input2);

                    //Console.WriteLine("Enter percentage for next class. Type done if finished:");
                    //string input3 = Console.ReadLine();
                    //double grade3 = Convert.ToDouble(input3);

                    //Console.WriteLine("Enter percentage for next class. Type done if finished:");
                    //string input4 = Console.ReadLine();
                    //double grade4 = Convert.ToDouble(input4);


            ////Another failed attempt.. Trying to pass input into an array
                    //string[] answer = new string[10];
                    //for (int i = 0; i < answer.length; i++)
                    //{
                    //    answer[i] = Console.ReadLine();
                    //}

            //simple solution:

            double grade1 = 79;
            double grade2 = 89;
            double grade3 = 96;
            double grade4 = 84;

            double GPA = (  ((grade1/20-1) + (grade2/20-1) + (grade3/20-1) + (grade4 / 20-1))/4 );
            //double GPA = (((grade1 + grade2 + grade3 + grade3 + grade4) / 20 - 4))/4; //why does this result not match the one above?

            Console.WriteLine($"Your GPA is {GPA}.");
            Console.ReadKey();

            //My solotion is clunky and needs to:
            //take input from user (in both percentage, gpa, and letter?)..this would have to be converted into points
            //store input in an array (after converting if needed
            //loop through question and responses until array if filled and each entry assigned to var? or does the array assignment take care of that problem
            // print out a grade for each subject and total GPA   
        }
    }
}
