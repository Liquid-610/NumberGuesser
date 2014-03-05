using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;

            int guess = 50;
            int guess2 = guess / 2;
            int guessh = guess2 + guess;
            int guessl = guess - guess2;




            while (guess == 50)
            {
                guess = 100 / 2;
                guess = (100 / 2) + guess2;


                Console.WriteLine("Is your number higher(h) , lower(l) or equal(e) to 50?");

                input = Console.ReadLine();

                if (input == "h")
                {
                    Console.WriteLine("{0}", guessh);

                }
                else if (input == "l")
                {
                Console.WriteLine("{0}", guessl);
                }

                else if (input =="e")

                    Console.WriteLine("I Win!!!!");
                
                

                
                }
           }

        }
    }

