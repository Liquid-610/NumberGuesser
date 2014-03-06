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
            int guessl = fitty / 2;
            int guessh = fitty + guessl;
            
            



            while (true) 
            {
               


                Console.WriteLine("Is your number higher(h) , lower(l) or equal(e) to {0}?", fitty);

                input = Console.ReadLine();

                if (input == "h" )
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

