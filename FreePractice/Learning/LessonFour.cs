using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreePractice.Learning
{
    /// <summary>
    /// TODO
    /// </summary>
    public static class LessonFour
    {
        /// <summary>
        /// //1. Create a Method That Prints a Message
        // Write a method named PrintMessage that takes no parameters and returns nothing. Inside
        //the method, print &quot; Hello, World!&quot; to the console.
        // modifier = public,static, internal ,private .
        // return type = void
        // method name =  print message
        // parameter = nothng 
        /// </summary>
        public static void PrintMessage()
        {
            Console.WriteLine("\"Hello, World\"");
        }

        /// <summary>
        /// 2. Add Two Numbers
        /// Write a method named AddNumbers that takes two integer parameters and returns their
        /// sum. Call the method and display the result.*/
        ///  declaring  function and variables.
        /// </summary>
        /// <param name="value1">number value to add number</param>
        /// <param name="value2">number value to add number</param>
        public static int AddNumbers(int value1, int value2)
        {
            int sum = value1 + value2;
            return sum;
        }
        /// <summary>
        /// 3. Multiply Two Numbers
        /// Write a method named Multiply that accepts two floating-point numbers as parameters and
        /// returns their product.*/
        /// declaring a method 
        /// modifier = public,internal,private , static.
        /// returntype =
        /// method name = Multiply
        /// calling the method and using the argument as two floating points.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static float Multiply(float v1, float v2)
        {
            float product = v1 * v2;
            return product;
        }

        /// <summary>
        /// 4. Find Maximum Number
        /// Create a method FindMax that takes two integer arguments and returns the larger of the
        /// two.
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        public static void FindMax(int a1, int a2)
        {
            if (a1> a2)
            {
                Console.WriteLine(a1 +" is greater");
            }
            else
                Console.WriteLine(a2 +" is greater ");

        }

        /// <summary>
        /// 5. Calculate Square
        /// Write a method Square that takes one integer parameter and returns its square.*/
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Square(int number)
        {
            int square = (number *number);
            return square;
        }
        /// <summary>
        /// 6. Check If a Number Is Even
        /// Write a method IsEven that accepts an integer as input and returns true if the number is
        /// even and false otherwise.
        /// </summary>
        /// <param name="integer"></param>
        /// <returns></returns>
        public static bool IsEven(int integer)
        {

            if (integer % 2 ==0)
                return true;
            else
                return false;

        }

    }
}
