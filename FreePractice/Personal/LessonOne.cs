using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FreePractice.Personal
{
    internal class LessonOne
    {
        public void ExcerciseOne()
        {
            // for loop .
            // use of counter .
            // increment and decrement.
            // multiplication and division series.
            // mod series in loop.
            // even and odd number list.


            //Console.WriteLine("write whole number series from 30 to 45.");
            //for (int i = 30; i <= 45; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            //////decrement.

            //Console.WriteLine("Write the number in descending order decreasing by 2.FRomm 106 to 306.");
            //for (int i =  306; i >= 106; i-=2 ) 
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadKey();

            //// Multiplication series.
            //int i;
            //int counter=0;
            //Console.WriteLine("Write down the ten multiples of 7 starting from 49.");
            //for (i = 49; i <= 112; i+=7)

            //{
            //    counter++;
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine("Multiple of 7 {0} times .", counter);
            //Console.ReadKey();
            /////....*****......\\\\\
            //Multiple/.
            //int i;
            //int b;
            //int counter=0;
            //for (i=7; i <= 16; i++)
            //{   b= i* 7;
            //    if (b >= 49) ;
            //    counter++;
            //    Console.WriteLine(b);
            //}
            //Console.WriteLine("The Values of multiple of 7 {0}'s times are above.", counter);
            //Console.ReadLine();

            //Divion and mod series.

            //Console.WriteLine("Write Down the Smallest  divisor for 18.");
            //int b=0;
            //for (int i =1 ; i<=18; i++)
            //{  b=18/i;
            

            //    Console.WriteLine(b);
            
            //}
            //Console.ReadKey();

            ////odd

            //Console.WriteLine("Wrie decending order of odds from 27.");
            //for (int i = 27; i >=1; i-=2) 
            //{ 
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            ///////...........**********............\\\\\\\\\
            ///Array

            int[] numbers = new int[5] ;
            numbers[0] = 20;
            numbers[1] = 30;
            numbers[2] = 40;
            numbers[3] = 50;
            numbers[4] = 60;
            Console.WriteLine(numbers[0]);
            
            Console.ReadKey();
            ///////////////////////////
            foreach (int number in numbers) 
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();


        }

    }
}
