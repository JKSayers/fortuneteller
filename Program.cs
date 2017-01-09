using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            int retire = age % 2;
            Console.Write(retire + " \n");

            Console.WriteLine("What is your birth month?(numeric answer only)");
            int birthMonth = int.Parse(Console.ReadLine());
            int money = birthMonth + 23;

            Console.WriteLine("What is your favorite ROYGBIV color?");
            string color = Console.ReadLine();
            color = "boat";
            Console.WriteLine("How many siblings do you have?");
            int sibsNumber = int.Parse(Console.ReadLine());
            int vacationHome = sibsNumber + 8;


            Console.Write(firstName + " " + lastName + " will retire in " + retire + " years with $" + money + " in the bank, a vacation home in " + vacationHome + " and a " + color);
        }
    }
}
