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
    class StringPlay
    {

        internal void BuilderString()
        {
            Console.WriteLine("Hello and welcome. \n"
                              + "We will alter and change some sentences.");
            Console.WriteLine("Please enter the sentence or phrase you want to use:");
            string initial = Console.ReadLine();


            

            //Odds and Even output
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your word/phrase will print with odd characters to the left and even characters to the right.");
            Console.ForegroundColor = ConsoleColor.Yellow;           Console.WriteLine(initial);
            Console.ForegroundColor = ConsoleColor.White;            Console.WriteLine(OddsandEvens(initial));

            //Vowels and Cons output
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\nYour word/phrade will print with consonants on the left, \npuncuation in the middle and vowels on the right.");
            Console.ForegroundColor = ConsoleColor.Yellow;           Console.WriteLine(initial);
            Console.ForegroundColor = ConsoleColor.White;            Console.WriteLine(ConsandVowels(initial));
            Console.WriteLine("\n");

        }


        //Odds and Evens Method
        //takes the string, removes spaces and then runs it through a for loop to seperate letters
        internal string OddsandEvens(string initial)
        {
            string odds = "";
            string evens = "";
            string newInitial = initial.Replace(" ", "");
            for (int i = 0; i < newInitial.Length; i++)
            {
                if (i % 2 == 0) odds += newInitial.Substring(i, 1);
                else evens += newInitial.Substring(i, 1);
            }
            return $"{odds} + {evens}";
        }


        //vowels and consonants method
        //creates a string with all the vowels removes spaces from initial string
        //runs check on each letter to determine if vowel or consonant and then places letter into appropriate string
        internal string ConsandVowels(string initial)
        {
            string consonants = "";
            string vowels = "";
            string puncuation = "";
            string stringCons = "bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ";
            string stringVowels = "aeiouyAEIOUY";
            string newInitial = initial.Replace(" ", "");
            
            for (int i = 0; i < newInitial.Length; i++)
            {
                if (stringVowels.Contains(newInitial.Substring(i, 1)) == true)
                    vowels += newInitial.Substring(i, 1);
                else if (stringCons.Contains(newInitial.Substring(i, 1)) == true)
                    consonants += newInitial.Substring(i, 1);
                else puncuation += newInitial.Substring(i, 1);
            }

            return $"{consonants} + {puncuation} + {vowels}";
        }
    }
}
