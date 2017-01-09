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
            //intro+firstName block
            Console.WriteLine("Hello there, I am the legendary fortune teller \"Zolthar the All-Knowing!!\"\n");
            Console.WriteLine("\n\n\nPlease.....tell Zolthar, what is your first name?");
            string firstName = Console.ReadLine();

            //lastname block
            Console.WriteLine("\nYes, that's right. " + firstName + "." + "\nZolthar aleady knew your first name....just wanted to be sure.\n");
            Console.WriteLine("BUT....... what is your last name?");
            string lastName = Console.ReadLine();

            //age/retire age block
            Console.WriteLine("\nWhat is your age?");
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

            //birthMonth/money block
            Console.WriteLine("\nReally? Zolthar thought you were younger than that.......\n");
            Console.Write("...and what is the number of your birth month?\n(numeric answers only: 1-12)\n");
            int birthMonth = int.Parse(Console.ReadLine());

            if (birthMonth <= 12 && birthMonth >= 1)
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

            //ROYGBIV/transportation block. Input is sent .ToUpper. 
            Console.WriteLine("\nWhat is your favorite ROYGBIV color? \nIf you do not know what an ROYGBIV color is, please enter 'HELP' so that Zolthar can assist you.");
            string color = Console.ReadLine();
            color = color.ToUpper();
            if (color == "HELP")
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, or Violet");
                color = Console.ReadLine();
            }
            
            {
                Console.WriteLine("Zolthar does not understand, please check your spelling and re-enter your answer.");
            }

            switch (color.ToUpper())
            {
                case "RED":
                    color = "an old hippie van that smells of music \nfestivals long since passed.";
                    break;
                case "ORANGE":
                    color = "1969 Dodge Dart \nwith a 340 and NOS in the trunk.";
                    break;
                case "YELLOW":
                    color = "dilapidated old unicycle.";
                    break;
                case "GREEN":
                    color = "Abrhams A-1 tank. \nIt's going to be an interesting retirement.";
                    break;
                case "BLUE":
                    color = "broken down \nmonster truck?(hey at least you went big right?)";
                    break;
                case "INDIGO":
                    color = "chaufer-driven \nstretch limosine(you corporate bourgie swine you....)";
                    break;
                case "VIOLET":
                    color = "straight up ballin' Cadillac \nfrom the 70's, you ARE that stylin' old guy.";
                    break;
                default:
                    color = "......you didn't read the HELP list did you? \nYou're Uber-ing your non-directions reading self around.";
                    break;

            }

            //Siblings/vacation home block. 
            Console.WriteLine("\nNow enter the number of siblings do you have:");
            int siblings = int.Parse(Console.ReadLine());
            string vacationHome = " ";
            if (siblings >= 0)
            {
                if (siblings == 0)
                {
                    vacationHome = "in London,";
                }
                else if (siblings == 1)
                {
                    vacationHome = "on the coast of Maine,";
                }
                else if (siblings == 2)
                {
                    vacationHome = "in Sao Paulo, Brazil,";
                }
                else if (siblings == 3)
                {
                    vacationHome = "in the the Dutch Alps,";
                }
                else if (siblings > 3)
                {
                    vacationHome = "in Sidney, Austraila,";
                }
            }
            else
            {
                vacationHome = ".....well, really it's just a timeshare\n.....in Cleveland.....in the winter,";
            }

            //output block
            Console.WriteLine("\n\n\nI'm looking into my crystal ball.....Yes. It's all starting to appear to me.");
            Console.WriteLine("Hit \"ENTER\" for your fortune.");
            Console.ReadLine();
            Console.Write("\n\n\n" + firstName + " " + lastName + " will retire in " + retire + " years with $" + birthMonth +
                          " in the bank,\na vacation home " + vacationHome + " and a " + color + "\n");

            Console.ReadKey();
        }
    }
}
