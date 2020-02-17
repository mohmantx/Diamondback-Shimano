using System;

namespace Lecture_2_17_20__HW2_Reprised_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm going to calculate GPA");

            Console.WriteLine("Enter grade for Accounting");
            double accounting = ReadDouble();

            Console.WriteLine("Enter grade for Marketing");
            double marketing = ReadDouble();

            Console.WriteLine("Enter grade for Economics");
            double economics = ReadDouble();

            Console.WriteLine("Enter grade for MIS");
            double MIS = ReadDouble();

            Console.WriteLine("Grade for Accounting: " + ConvertToLetterGrade(accounting));
            Console.WriteLine("Grade for Marketing: " + ConvertToLetterGrade(marketing));
            Console.WriteLine("Grade for Economics: " + ConvertToLetterGrade(economics));
            Console.WriteLine("Grade for MIS: " + ConvertToLetterGrade(MIS));

            Console.ReadKey();
        }

        static string ConvertToLetterGrade(double gradepoint)
        {
            if (gradepoint >= 4)
            {
                return "A";
            }
            else if (gradepoint >= 3)
            {
                return "B";
            }
            else if (gradepoint >= 2)
            {
                return "C";
            }
            else if (gradepoint >= 1)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }


        static double ReadDouble()
        {
            while(true)
            {
                Console.WriteLine("Input a double:");
                string input = Console.ReadLine();
                double converted;
                
                //TryParse will return true if can take input and output converted
                if(double.TryParse(input, out converted))
                {
                    return converted;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        
    }

}
