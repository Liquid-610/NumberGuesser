﻿using System;
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
            int numguess = 1;
            numguess = numguess++;

            while (numguess <= 7) 
            {
               


                Console.WriteLine("Is your number higher(h) , lower(l) or equal(e) to {0}?");

                input = Console.ReadLine();

                if (input == "h")
                {
                    Console.WriteLine("i work");

                }
                else if (input == "l")
                {
                Console.WriteLine("i work 2");
                }

                else if (input =="e")

                    Console.WriteLine("I Win!!!!");

                if (numguess == 8)
                {
                    Console.WriteLine(" I Lose :( ");
                }

              
                }
             
           }
        
        }
    }

