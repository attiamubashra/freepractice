using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace Program3
{
    public class Operators
    {

        public static void Main()
        {//Arithematic operator
         // +,-,/,*,%
            Console.WriteLine("Enter time in minutes.");
            int min = int.Parse(Console.ReadLine());

            int hour = min /60;
            int minutes = hour * min/60;
            Console.WriteLine(hour);
            Console.WriteLine(minutes);

            Console.ReadKey();
        }
        

    }
}
    
