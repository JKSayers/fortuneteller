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

            switch (retire)
            {
                case 0:
                    retire = 32;
                    break;
                case 1:
                    retire = 15;
                    break;
            }

            Console.Write("What is the number of your birth month?\n(numbers only - ie: 01-12)\n");
            int birthMonth = int.Parse(Console.ReadLine());

            if (birthMonth <= 12 || birthMonth >= 1)
            {
                if (birthMonth <= 12 && birthMonth >= 9)
                {
                    birthMonth = -33000;
                }
                else if (birthMonth <= 8 && birthMonth >= 5)
                {
                    birthMonth = 90000;
                }
                else if (birthMonth <= 4 && birthMonth >= 1)
                {
                    birthMonth = 42000000;
                }
            }
            else
            {
                birthMonth = 0;
            }


            Console.WriteLine("What is your favorite ROYGBIV color? \nIf you do not know what an ROYGBIV color is, please enter 'Help'");
            string color = Console.ReadLine();
            color = color.ToUpper();
            if (color == "HELP")
            {
                Console.WriteLine("R=Red, O=Orange, Y=Yellow, G=Green, B=Blue, I=Indigo, V=Violet");
                color = Console.ReadLine();
            }    

                switch (color.ToUpper())
                {
                    case "R":
                        color = "hippie Van that smells of music festivals long since passed.";
                        break;
                    case "O":
                        color = "1969 Dodge Dart with a 340 and NOS in the trunk.";
                        break;
                    case "Y":
                        color = "dilapidated old unicycle.";
                        break;
                    case "G":
                        color = "Abrhams A-1 tank.";
                        break;
                    case "B":
                        color = "broken down monster truck?(hey at least it's big right?)";
                        break;
                    case "I":
                        color = "chaufer-driven stretch limosine.";
                        break;
                    case "V":
                        color = "straight up ballin' Cadillac from the 70's, you're that stylin' old guy.";
                        break;
                    default:
                        color = "You didn't read the help list did you?";
                        break;

                }
            
            Console.WriteLine("How many siblings do you have?");
            int vacationHome = int.Parse(Console.ReadLine());
            string vHome = " ";
            if (vacationHome >=0)
            {
                if (vacationHome == 0)
                {
                    vHome = "in London,";
                }
                else if (vacationHome == 1)
                {
                    vHome = "on the coast of Maine,";
                }
                else if (vacationHome == 2)
                {
                    vHome = "in Sao Pao, Brazil,";
                }
                else if (vacationHome == 3)
                {
                     vHome = "in the the Dutch Alps,";
                }
                else if (vacationHome > 3)
                {
                     vHome = "in Sidney, Austraila,";
                }
            }
            else
            {
                 vHome = "well, really it's just a timeshare.....in Cleveland.....in the winter,";
            }
            


            Console.Write(firstName + " " + lastName + " will retire in " + retire + " years with $" + birthMonth + " in the bank,\na vacation home " + vHome + " and a " + color + "\n");
        }
    }
}
