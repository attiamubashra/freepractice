using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreePractice.Udemy
{
    internal class SectionThree
    {
        /// <summary>
        /// Use of if elase statements
        /// </summary>
        public void IfElsePractice()
        {
            string item = Console.ReadLine().ToLower();
            if (item == "cell")
            {
                Console.WriteLine("its price is 3 Pounds.");
            }
            else if (item== "brush")
            {
                Console.WriteLine("Its price is 9 pounds.");
            }
            else if (item=="fan")
            {
                Console.WriteLine("Its price is 50 pounds");
            }
            else
            {
                Console.WriteLine("Sorry,This product is not Available here.");
            }


            if (item == "cell" || item == "brush" || item == "fan")
            {
                Console.WriteLine($"Do you want to purchase this {item}.Enter by  Yes/No  ");
                string purchase = Console.ReadLine().ToLower();

                if (purchase== "yes")
                {
                    Console.WriteLine("How do you want to pay ?");
                    Console.ReadLine();
                    Console.WriteLine("Enter yours adress.");
                    Console.ReadLine();
                    Console.WriteLine($"We will send {item} on your adress.");
                }
                else
                {
                    Console.WriteLine("Thank you for yours time.");
                }
            }

            Console.ReadKey();
        }

        public void SecretNumber()
        {
            int secretNumber = 50;
            int matchNumber = 0;

            Console.WriteLine("Match yours number and win prize.");

            //Console.WriteLine("Are You interested in playing match number?Yes/NO");
            //string interested = Console.ReadLine();

            //if (interested == "yes")
            Console.WriteLine("Write your Number.");
            while (matchNumber != secretNumber)
            {
                matchNumber = int.Parse(Console.ReadLine());
                {
                    if (matchNumber > secretNumber)
                    {
                        Console.WriteLine("The number is too big.TRY again.");
                        matchNumber = int.Parse(Console.ReadLine());
                    }
                    else if (matchNumber < secretNumber)
                    {
                        Console.WriteLine("The Number is too small.TRY again.");
                        matchNumber = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Congratulations. YOU HAVE WON THE PRIZE.");
                    }
                }
                //else 
                {
                    // Console.WriteLine("No worries, We will play later.");
                }

                Console.ReadKey();
            }
        }

        public void BoiledEgg()
        {
            Console.WriteLine("Do You Want to boil eggs.");
            string userInput = Console.ReadLine().ToLower().Trim();
           
               
            int counter = 0;
            while (userInput == "yes") 
            {
                counter++;
                Console.WriteLine("Have u boiled  egg?");
                userInput = Console.ReadLine().ToLower().Trim();
                Console.WriteLine("Do you want to boil another egg?");
                 userInput =Console.ReadLine().ToLower().Trim();
            }

            if (userInput == "no")
            {
                Console.WriteLine("Lets play another game.");
            }
            else
            {
                Console.WriteLine(" You boiled total {0} eggs today.", counter); 
            }

            Console.ReadKey();
        }
    }
}