using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProcedures
{
    class Fibonacci
    {

        //Recursive method
        //computes Sequence 
        internal static int Foutput(int length)
        {
            if (length <= 2)
            {
                return 1;
            }
            else
            {
                return Foutput(length - 2) + Foutput(length - 1);
            }

        }


        //Results method where
        //console gets and returns value based on position
        internal void Results()
        {
            Console.WriteLine("Fibonacci Sequence. This is a sequence of numbers where the current\n" +
                              "number is the sum of the two numbers prior to it in the sequence.\n" +
                              "It starts off 1, 1, 2, 3, 5, 8, etc.\n" +
                              "What position would you like to calculate the sequence to?");
            int howlong = Convert.ToInt32(Console.ReadLine());
            Console.Write($"You wanted to calculate the number at position: ");
            Console.ForegroundColor = ConsoleColor.Cyan;                                     Console.Write($"{howlong}");
            Console.ForegroundColor = ConsoleColor.White;           Console.Write($"\nThe number at this position is: ");
            Console.ForegroundColor = ConsoleColor.Cyan;                         Console.Write($"{ Foutput(howlong)}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
