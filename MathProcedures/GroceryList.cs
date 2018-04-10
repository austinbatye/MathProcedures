using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathProcedures
{
    class GroceryList
    {
        string combined;                                                     //Variables defined
        string grocery;
        string unit;
        int quantity;

        internal void Input()
        {
            var groceries = new List<string>();

            while (true)
            {
                Console.Write("Please type in the name of your grocery: ");            //combines grocery + unit + quantity into one string
                grocery = Console.ReadLine();                                            
                Console.Write("Please enter its unit type (ex. dozen, 5pack, ounces: "); 
                unit = Console.ReadLine();                                               
                Console.Write("Lastly, please enter the quantity: ");
                string stringQuantity = Console.ReadLine();
                        if (int.TryParse(stringQuantity, out quantity))                   //If statement ensures quantity is a  number
                        { }
                        else
                        {
                            Console.WriteLine("The quantity entered must be a number.\nPlease try again.");
                            continue;
                        }

                combined = $"{grocery}\t\t{unit}\t\t{quantity}";                            //Combines each portion of the list into one    
                groceries.Add(combined);                                                    //value and adds to list   
                
                Console.Write("Do you have more to add or is that it?");                           //console prompt for where to go
                Console.ForegroundColor = ConsoleColor.DarkMagenta;                   
                Console.WriteLine(" (Y/N)\n");                                        
                Console.ForegroundColor = ConsoleColor.White;                         


                if (Console.ReadKey(true).Key == ConsoleKey.Y)                                //If statement for Adding more 
                {
                    continue;
                }

                if (Console.ReadKey(true).Key == ConsoleKey.N)                     //If statement displaying completed list
                {
                    Console.Clear();
                    Console.WriteLine("Here is your LIST:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\tName\t\tUnit\t\tQuantity");
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (string line in groceries)                             //ForEach displaying each index of list
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"\t{line}\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (true)     //While loop to either start new list or go back to Program.Bulk(main menu)
                    {
                        Console.Write("Press '");                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("space");                                Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("' to create another list, or '");     Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("enter");                                Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("' to return to the main menu.");
                            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                            {
                                Console.Clear();
                                GlistMain();
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
                else                                                           //Else portion for if key pressed not valid
                {
                    Console.WriteLine("Invalid Command. Please try again.");
                    Console.Write("Do you have more to add or is that it?");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(" (Y/N)\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }
        }


        internal void GlistMain()                                                       //Entry point for Grocery List Class
        {


            Console.Write("Your grocery list will be built and exported" +
                          " to a new file when you are finished.\n" +
                          "Prepare to build your list.\n");
                              
            Input();
            
        }
    }
}
