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
        /// <summary>
        /// Two integer variables.
        /// Find out mutliplication value.
        /// Find out  quotient Value.
        /// string iterpolation method.
        /// </summary>

        public void ExcerciseThree() 
        {
            int firstNumber = 10;
            int secondNumber = 5;

            int product = firstNumber * secondNumber;
            int quotient = firstNumber / secondNumber;

            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");

            Console.ReadKey();
        }
        /// <summary>
        /// Two integer variables.
        /// Modulous operatot ...
        /// remainder should be 1.

        /// </summary>
        public void ExcerciseFour()
        {
            int firstModnumber = 50;
            int secondModNumber = 7;

            int solution = firstModnumber % secondModNumber;

            Console.WriteLine("Remainder : {0}", solution);

            Console.ReadKey();

        } 
        /// <summary>
        //// Two integer variables.
        //// Rectangle area output should be 20.
        //// Multiplication method.
        //// CamelCase. 
        //// String formating method. 
        /// </summary>

        public void ExceerciseFive()
        {
            int length = 10;
            int width = 2;

            int areaOfRectangle = length * width;

            Console.WriteLine("Area of rectangle : {0}", areaOfRectangle);

            Console.ReadKey();
        }
        /// <summary>
        ///  One integer variable 'age'.
        ///  if and else case method.
        ///  camelCase .
        ///  String interpolation method.
        /// </summary>
        public void ExcerciseSix() 
        {
            int age = 69;
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are minor.");
            }

            Console.ReadKey();
        }
        /// <summary>
        ///  Two integer variable.
        ///  if and else statement method.
        ///  Choose which number  is greater.
        /// </summary>
        public void ExcerciseSeven()
        {
            int firstInteger = 15;
            int secondInteger = 15;

            if (firstInteger > secondInteger)
            {
                Console.WriteLine(firstInteger + " is greater than " + secondInteger);
            }
            else if (firstInteger < secondInteger)
            {
                Console.WriteLine(secondInteger + " is greater than " + firstInteger);
            }
            else
            {
                Console.WriteLine("Both Number are equal.");
            }

            Console.ReadKey();

        }
        /// <summary>
        /// Declare an integer variable assign it value.
        /// Modulous operator.
        /// if and else method.
        /// camelCase .
        /// String concatination.
        /// </summary>
        public void ExcerciseEight() 
        {
            int integer = 64;

            if (integer % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            Console.ReadKey();
        }
        /// <summary>
        /// if and else statements.
        /// declaring a variable assigning it a value.
        /// camelCase method.
        /// string interpolation .
        /// </summary>
        public void ExcerciseNine() 
        {
            int score = 33;

            if (score >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade C");
            }
        }public void ExcerciseTen() 
        {
        
        }

    }  
    
     
}     
   

