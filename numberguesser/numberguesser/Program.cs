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

            int fitty = 50;
            int guess = fitty + 25;
            int guess2 = fitty / 2;
            //int guessh = guess2 + guess;
            //int guessl = guess - guess2;
            



            while (guess <= 100) 
            {
               


                Console.WriteLine("Is your number higher(h) , lower(l) or equal(e) to {0}?", fitty);

                input = Console.ReadLine();

                if (input == "h")
                {
                    Console.WriteLine("{0}", guess);

                }
                else if (input == "l")
                {
                Console.WriteLine("{0}", guess2);
                }

                else if (input =="e")

                    Console.WriteLine("I Win!!!!");
                
                

                
                }
           }

        }
    }

