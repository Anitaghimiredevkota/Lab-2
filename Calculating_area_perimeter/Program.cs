using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculating_area_perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, Area, perimeter;
            String Choice;

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            do
            {
                Console.WriteLine("Enter values of length : ");
                length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter values of width : ");
                width = double.Parse(Console.ReadLine());

                Area = length * width;
                Console.WriteLine("Area = " + Area);
                perimeter = 2 * (length + width);
                Console.WriteLine("Perimeter = " + perimeter);

                Console.WriteLine("Do you want to continue measuring rooms! YES or NO");
                Choice = Console.ReadLine();
                if (Choice == "YES" || Choice == "NO") { }

            } while (Choice == "YES");


        }

    }
}

            


     

