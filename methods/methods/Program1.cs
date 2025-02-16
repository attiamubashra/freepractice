using System.ComponentModel;
using System.Net.Cache;
using System.Security.Principal;

namespace methods
{
    internal class Functions
    {
        // static ,void, non parameterized,claas name caliing method,
        // positinal hard core arguments,

        public static void FriendsForEver()
        {
            string name_1 = "Ali";

            Console.WriteLine("There were two friends. ");
            Console.WriteLine("Both sudied in same school. ");
            Console.WriteLine("one friend name was {0}", name_1);

        }

        // Non static/instance method or object method 
        // return type 
        // parameterized 
        // one argument is input

        public int Numbers(int num1, int num2)
        {
            int division = num1 / num2;
            return division;

        }

        // non ststic/instancised or object method.
        // two different parameters.
        // reurn type.
        // named argument.
        // multiple time called method.

        public void EmployeeData(int age, string name)
        {

            Console.WriteLine("Employee  age is :{0}", age);
            Console.WriteLine("Employee name is :{0}", name);


        }
        // non static 
        // parameterisd
        // default argument 
        public double Subtractions(double a , double b= 0 ) 
        {
            double c = a-b;
            return c;
        }

        public void Words(string name= "unknown") 
        {
            Console.WriteLine("Your name is :"+ name);

        }
        static void Main(string[] args)
        {
            Functions.FriendsForEver();
            Console.WriteLine(Functions.FriendsForEver);


            // non static so making object .
            Functions div = new Functions();
            // Takin one int numi value from user as input.
            Console.WriteLine("Write a whole number .");
            int input = int.Parse(Console.ReadLine());

            div.Numbers(input, 2);

            Console.WriteLine("The divion of {0} from {1} is : {2} ", input,2  , div.Numbers(input, 2));


            // object formation 
            Functions employee = new Functions();
            // named arguments.
            employee.EmployeeData(name: "ahmed", age: 23);
            employee.EmployeeData(name: "samar", age: 34);
            employee.EmployeeData(name: "wed", age: 21);
            employee.EmployeeData(name: "cb", age: 56);

            // object formation
            Functions subtract = new Functions();
            double solution =subtract.Subtractions(4);

            Console.WriteLine(solution);

            // object formation, optional parameter.
            Functions name_1 = new Functions();
            name_1.Words();


            Console.ReadKey();
            Console.Beep();
        }
            
    }
}