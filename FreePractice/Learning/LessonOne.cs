using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreePractice.Learning
{
    internal class LessonOne
    {
        /// <summary>
        /// Two variables .....
        /// 1- integer assign value 10
        /// 2- String assign value john
        /// </summary>
        public void ExcerciseOne()
        {
            int number = 10;
            string name = "john";

            Console.WriteLine($"Number: {number}");
            Console.WriteLine("Name: " + name);

            Console.ReadKey();
        }

        /// <summary>
        /// Declaring Two variables.
        /// find out sum .
        /// find out differrence.
        /// string formating method.
        /// </summary>
        public void ExcerciseTwo() 
        {
           int number_1 = 10;
            int number_2 = 5;

            int sum = number_1 + number_2;
            int difference = number_1 - number_2;

            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Difference: {0}", difference);

            Console.ReadKey();
            
        }
        
    }
}
