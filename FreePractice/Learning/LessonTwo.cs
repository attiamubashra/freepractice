using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FreePractice.Learning
{
    /// <summary>
    /// TODO
    /// </summary>
    internal class LessonTwo
    {
        /// <summary>
        /// Print numbers 1 to 10.
        /// </summary>
        public void ExcerciseOne()
        {
            for (int numbers = 0; numbers <= 10; numbers++)
            {
                Console.WriteLine(numbers);
            }

            Console.ReadKey();

        }

        /// <summary>
        /// 
        /// </summary>
        public void ExcerciseTwo()
        {
            for (int evenNumbers = 1; evenNumbers <= 20; evenNumbers++)
            {
                evenNumbers += 1;
                Console.WriteLine(evenNumbers);
            }

            Console.ReadKey();
        }
        public void ExcerciseThree()
        {
            for (int multiple = 0; multiple <=10; multiple++)
            {
                multiple *= 5;
                Console.WriteLine(multiple);
                multiple /= 5;
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 4. Calculate the sum of numbers from 1 to 50.
        /// </summary>
        public void ExcerciseFour()
        {
            int sum = 0;
            for (int i = 1; i <=50; i++)
            {
                // sum += i;
                sum = sum + i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }


        /// <summary>
        /// Print the factorial of a given number (e.g., 5).
        /// 5! = 5 X 4 X 3 X 2 X 1 = 120
        /// </summary>
        public void ExcerciseFive()
        {
            int factor = 1;
            for (int i = 5; i >=1; i--)
            {
                factor = factor * i;

            }
            Console.WriteLine(factor);
            Console.ReadKey();
        }
        /// <summary>
        /// 6. Print the first 10 Fibonacci numbers.
        /// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34,  
        /// </summary>

        public void ExcerciseSix()
        {
            int a = 0, b = 1, c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 1; i<=3; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a= b + c;
                Console.WriteLine(a);
                b=a+c;
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Print all characters in the string "Hello".
        /// </summary>
        public void ExcerciseSeven()
        {
            string hello = "Hello";

            for (int i = 0; i<hello.Length; i++)
            {
                Console.WriteLine(hello[i]);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Print all numbers divisible by 3 between 1 and 30.
        /// </summary>
        public void ExcerciseEight()
        {
            #region First Option
            //int a = 3;
            //for (int i = 1; i<=10; i++)
            //{

            //    Console.WriteLine(a*i);
            //}
            #endregion

            #region Second Option
            //for (int i = 1; i<=30; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            for (int i = 30; i >= 1; i-=3)
            {
                int a = i/3;
                Console.WriteLine(a);
            }
            
            Console.ReadKey();
        }

        /// <summary>
        /// Reverse a number (e.g., 123 -> 321).
        /// </summary>
        public void ExcerciseNine()
        {
            sbyte a = 123;
            sbyte b = 3;
            Console.WriteLine(b);
            // please put your code here.
            Console.ReadKey();
        } 
        
        

    }
}