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
            int numguess = 1;
            numguess = numguess++;

            int guess, low = 0, high = 100;


            while (numguess <= 7) 
            {
               
                guess = (low + high) / 2;

                Console.WriteLine("Is your number higher(h) , lower(l) or equal(e) to {0}?",guess);

                input = Console.ReadLine();

               

                switch (input)
                {
                    case "h":

                        low = guess + 1;
                        Console.WriteLine("Is your number higher(h) , lower(l) or equal(e) to {0}?", guess);
                        break;

                    case "l": 
                        high = guess - 1;
                        Console.WriteLine("Is your number higher(h) , lower(l) or equal(e) to {0}?", guess);
                        break;

                    case "e":
                        Console.WriteLine("I Win!!! Do you want to play again? (y) or (n)");
                        break;

                        if (input == "y")
                        {
                            
                        }
                        else
                        {
                            break;
                        }
                }

                       
                        
                }

               

              
                }
             
           }
        
        }
    

