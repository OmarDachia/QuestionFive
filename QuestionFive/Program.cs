using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#4 Write a Promgram to enter marks of a student in 5 subjects & calculate the percentage.");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("User input:->");
            Console.WriteLine("+++++++++++++");

            double sub1 = 0, sub2 = 0, sub3 = 0, sub4 = 0, sub5 = 0, percentage = 0;
            Console.WriteLine("Enter the Subject 1:->");
            double.TryParse(Console.ReadLine(), out sub1);
            Console.WriteLine("Enter the Subject 2:->");
            double.TryParse(Console.ReadLine(), out sub2);
            Console.WriteLine("Enter the Subject 3:->");
            double.TryParse(Console.ReadLine(), out sub3);
            Console.WriteLine("Enter the Subject 4:->");
            double.TryParse(Console.ReadLine(), out sub4);
            Console.WriteLine("Enter the Subject 5:->");
            double.TryParse(Console.ReadLine(), out sub5);
            

           
            percentage = ((sub1+sub2+sub3+sub4+sub5)/500)*100;

            Console.WriteLine("Result:->");
            Console.WriteLine("*********");
            Console.WriteLine(string.Format("Percentage {0} ", percentage));
            Console.ReadKey();
        }
    }
}
