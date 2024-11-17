using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreePractice.Udemy
{
    internal class Structure
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

    }
}
