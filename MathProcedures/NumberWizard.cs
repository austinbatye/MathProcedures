using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProcedures
{
    class NumberWizard
    {
        static Random r = new Random();
        public int max = 1000;
        public int min = 1;
        public int guess = r.Next(1, 1000);

        internal void Start()
        {
            StartGame();
        }

        internal void StartGame()
        {
            
            Console.WriteLine("=================================================\n" +
                              "Welcome to Number Wizard\n" +
                              "Pick a number in your head, but don't tell me!");

            Console.Write("The highest number you can pick is ");
            Console.ForegroundColor = ConsoleColor.Cyan;                                              Console.Write(max);
            Console.ForegroundColor = ConsoleColor.White;          Console.Write("\nThe lowest number you can pick is ");
            Console.ForegroundColor = ConsoleColor.Cyan;                                              Console.Write(min);
            Console.ForegroundColor = ConsoleColor.White;         Console.Write("\nIs the number higher or lower than ");
            Console.ForegroundColor = ConsoleColor.Cyan;                                  Console.Write(guess + "?\nUp");
            Console.ForegroundColor = ConsoleColor.White;                                   Console.Write(" = higher, ");
            Console.ForegroundColor = ConsoleColor.Cyan;                                           Console.Write("Down");
            Console.ForegroundColor = ConsoleColor.White;                                    Console.Write(" = lower, ");
            Console.ForegroundColor = ConsoleColor.Cyan;                                         Console.Write("Return");
            Console.ForegroundColor = ConsoleColor.White;                                   Console.Write(" = equal.\n");
            Update();
        }

        internal void Update()
        {
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.UpArrow)
                {
                    min = guess;
                    NextGuess();
                }
                else if (Console.ReadKey().Key == ConsoleKey.DownArrow)
                {
                    max = guess;
                    NextGuess();
                }
                else if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("I won.");
                    PlayAgain();
                }
            }
        }

        internal void PlayAgain()
        {
            while (true)                         //While loop to either start new game or go back to Program.Bulk(main menu)
            {
                Console.Write("Press '"); Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("space"); Console.ForegroundColor = ConsoleColor.White;
                Console.Write("' to play another game, or '"); Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("enter"); Console.ForegroundColor = ConsoleColor.White;
                Console.Write("' to return to the main menu.");
                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    StartGame();
                }
                else if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    System.Threading.Thread.Sleep(1500);
                    Program.Bulk();
                }
                else
                {
                    Console.WriteLine("Command not recognized, please try again.");
                    continue;
                }
            }
        }

        internal void NextGuess()
        {
            guess = ((min + max) / 2);
            Console.Write("Higher or lower than " + guess + "?");
            Console.ForegroundColor = ConsoleColor.Cyan;                    Console.Write("\nUp");
            Console.ForegroundColor = ConsoleColor.White;            Console.Write(" = higher, ");
            Console.ForegroundColor = ConsoleColor.Cyan;                    Console.Write("Down");
            Console.ForegroundColor = ConsoleColor.White;             Console.Write(" = lower, ");
            Console.ForegroundColor = ConsoleColor.Cyan;                  Console.Write("Return"); 
            Console.ForegroundColor = ConsoleColor.White;            Console.Write(" = equal.\n");
            Update();
        }
    }
}
