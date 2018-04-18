using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathProcedures
{
    class Program
    {

        //.
        //Bulk holds bulk of navigation for program
        //.
        internal static void Bulk()
        {
            while (true)
            {

                //Intro and Choose math problem
                Console.ForegroundColor = ConsoleColor.Gray;        //Color gray
                Console.WriteLine("Welcome to the Procedures program. \n" +
                                  "Here a selection of programs have been compiled into one master program.\n" +
                                  "Below is the selection of programs. \n" +
                                  "Press the corresponding letter for each procedure.");
                Console.ForegroundColor = ConsoleColor.Yellow;      //Color yellow
                Console.Write("     a. Fibonacci Sequence.\t\t\t b. Number Wizard\n" +
                              "     c. Grocery List\t\t\t\t d. Playing with Words");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n     To exit the program please type 'quit' or 'done'.\n");
                Console.ForegroundColor = ConsoleColor.White;       //Color white
                string choice = Console.ReadLine().ToLower();       //Choose line

                
                //If statement determining method to call
                if (choice == "a")
                {
                    var fibonacci = new Fibonacci();
                    fibonacci.Results();
                    Breaker();
                }

                else if (choice == "b")
                {
                    var numberwizard = new  NumberWizard();
                    numberwizard.Start();
                    Breaker();
                }
                else if (choice == "c")
                {
                    var grocerylist = new GroceryList();
                    grocerylist.GlistMain();
                }
                else if (choice == "d")
                {
                    var stringplay = new StringPlay();
                    stringplay.BuilderString();
                    Breaker();
                }
                else if (choice == "quit" || choice == "done")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Command not recognized. Returning to main menu; please try again.");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    continue;
                }
            }



        }


        //Method breaker
        //for neatness between cycles/iterations
        internal static void Breaker()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Press enter to return to main menu.");
                Console.ForegroundColor = ConsoleColor.White;
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Returning you to main menu shortly.");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Bulk();
                }
                else
                {
                    continue;
                }
            }
        }

        //Main
        static void Main(string[] args)
        {
            Bulk();
        }
    }
}
