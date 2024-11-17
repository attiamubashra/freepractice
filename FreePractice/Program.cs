using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

/* ==============Use of if elase statements ============== */
/*
 * Console.WriteLine("Which item do you want to buy ? cell or brush or fan ");
string item = Console.ReadLine().ToLower();
if (item("cell"))
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

Console.ReadKey();*/


/* ==============Use of AND conditions ============== */

/*
Console.WriteLine("Check out  the Weather today.rainy, cloudy, sunny, windy, thunder");
string weather = Console.ReadLine();
bool rainy = true;
bool cloudy = true;
bool sunny = true;
bool windy = true;
bool thunder = true;
Console.WriteLine(" Choose your dress according to weather.");
if (weather.Contains("rainy") && weather.Contains("cloudy"))
{
    Console.WriteLine("Take umbrella and wear rain coat.");
}
 else if  (sunny && windy)
{
    Console.WriteLine("Wear hat and cotton suit.");
}
 else if (thunder && rainy)
{
    Console.WriteLine("Do not go outside.");
}
 else if (cloudy && windy && rainy)
{
    Console.WriteLine("Wear waterproof jackets and shoes.");
}
Console.ReadKey();
*/

/* ============== Excercise 1:  ============== */
// Two variables .....
// 1- integer assign value 10
// 2- String assign value john



//int number = 10;
//string name = "john";

//Console.WriteLine($"Number: {number}");
//Console.WriteLine("Name: " + name);

//Console.ReadKey();

///* ============== Excercise 2:  ============== */
//// Declaring Two variables.
//// find out sum .
////find out differrence.
////string formating method.

//int number_1 = 10;
//int number_2 = 5;

//int sum = number_1 + number_2;
//int difference = number_1 - number_2;

//Console.WriteLine("Sum: {0}", sum);
//Console.WriteLine("Difference: {0}", difference);

//Console.ReadKey();


///* ============== Excercise 3:  ============== */
////Two integer variables.
////Find out mutliplication value.
////Find out  quotient Value.
////string iterpolation method.

//int firstNumber = 10;
//int secondNumber = 5;

//int product = firstNumber * secondNumber;
//int quotient = firstNumber / secondNumber;

//Console.WriteLine($"Product: {product}");
//Console.WriteLine($"Quotient: {quotient}");

//Console.ReadKey();

///* ============== Excercise 4:  ============== */
//// Two integer variables.
//// Modulous operatot ...
//// remainder should be 1.

//int firstModnumber = 50;
//int secondModNumber = 7;

//int solution = firstModnumber % secondModNumber;

//Console.WriteLine("Remainder : {0}", solution);

//Console.ReadKey();

///* ============== Excercise 5:  ============== */
//// Two integer variables.
//// Rectangle area output should be 20.
//// Multiplication method.
//// CamelCase. 
//// String formating method. 

//int length = 10;
//int width = 2;

//int areaOfRectangle = length * width;

//Console.WriteLine("Area of rectangle : {0}", areaOfRectangle);

//Console.ReadKey();

///* ============== Excercise 6:  ============== */
////  One integer variable 'age'.
////  if and else case method.
////  camelCase .
////  String interpolation method.

//int age  = 69;
//if (age >= 18)
//{
//    Console.WriteLine("You are an adult.");
//}
//else
//{
//    Console.WriteLine("You are minor.");
//}

//Console.ReadKey();

///* ============== Excercise 7:  ============== */
//// Two integer variable.
//// if and else statement method.
//// Choose which number  is greater.

//int firstInteger = 15;
//int secondInteger = 15;

//if (firstInteger > secondInteger)
//{
//    Console.WriteLine(firstInteger + " is greater than " + secondInteger);
//}
//else if (firstInteger < secondInteger) 
//{
//    Console.WriteLine(secondInteger + " is greater than " + firstInteger);
//}
//else
//{
//    Console.WriteLine("Both Number are equal.");
//}

//Console.ReadKey();

///* ============== Excercise 8:  ============== */

//// Declare an integer variable assign it value.
//// Modulous operator.
//// if and else method.
//// camelCase .
//// String concatination.

//int integer = 64;

//if (integer % 2 == 0)
//{
//    Console.WriteLine("The number is even.");
//}
//else 
//{
//    Console.WriteLine("The number is odd.");
//}

//Console.ReadKey();

///* ============== Excercise 9:  ============== */
//// if and else statements.
//// declaring a variable assigning it a value.
//// camelCase method.
//// string interpolation .

//int score = 33;

//if (score >= 90)
//{
//    Console.WriteLine("Grade A");
//}
//else if (score >= 80)
//{
//    Console.WriteLine("Grade B");
//}
//else if (score >= 70)
//{
//    Console.WriteLine("Grade C");
//}



///* ============== ;;;;;;;;;:  ============== */

//int number = 0;
//Console.WriteLine(number);      //0

////pre incrementing 
//Console.WriteLine(++number);   //1

////post incrementing

//Console.WriteLine(number++);  //1
//Console.WriteLine(number);    //2

//int A = 23;
////PRe Increment

////++A;
////Console.WriteLine(A); //24

////Post increment
//Console.WriteLine(A++);//23
//Console.WriteLine(A);//24

//int H = 45;
////// pre decrementing 
////--H;
////Console.WriteLine(H);//44
////Post decrementing 
//H--;
//Console.WriteLine(H);

///* ============== ;;;;;;;;;:  ============== */

////ddition assighnment operator
//int Y = 62;
//Y += 2;
//Console.WriteLine(Y);
////Subtraction assignment
//Y -= 4;
//    Console.WriteLine(Y);

//// Modulo assignment 
//Y %= 7;

//// multiplication assignment 
//Y *= 9;
//Console.WriteLine(Y);

////division assignment  operator 
//Y /= 6;
//Console.WriteLine(Y);
//Console.WriteLine(Y);

///* ============== ;;;;;;;;;:  ============== */


//// string into integer conversion
//Console.WriteLine("enter a number.");
//string number = Console.ReadLine();

//int numberA = int.Parse(number);

//Console.WriteLine($"The entered number is {numberA}");

//Console.WriteLine("Enter a decimal number.");
//string decimalNumber = Console.ReadLine();

//decimal numberB = decimal.Parse(decimalNumber);

//Console.WriteLine("your entery n
//umber is " + numberB);
//Console.ReadKey();

///* ============== ;;;;;;;;;:  ============== */


// try pase method.
//Console.WriteLine("Enter an integer.");
//string integer = Console.ReadLine();

//int integerA;
//bool integer2 = int.TryParse(integer, out integerA);

//if (integer2)
//{
//    Console.WriteLine("You can enter through the gate.");
//}
//else 
//{
//    Console.WriteLine("Its wrong Number.");
//}
//Console.ReadKey();

///* ============== ;;;;;;;;;:  ============== */

//// addition calculator
//Console.WriteLine("Enter a decimal number.");
//string numberA = Console.ReadLine();

//float numberOne = float.Parse(numberA);

//Console.WriteLine("Enter a second decimal number.");
//string numberB = Console.ReadLine();

//float numberTwo = float.Parse(numberB);

//// addition 
//float addition = numberOne + numberTwo;

//Console.WriteLine("The addition of two given decimal is "+ addition);

//Console.ReadKey();


///* ============== ;;;;;;;;;:  ============== */

Console.WriteLine("Enter a number.");
string number = Console.ReadLine();
int klm;

bool trueNumber = int.TryParse(number, out klm);

if (trueNumber)
{
    Console.WriteLine("Good Luck.");
}
else 
{
    Console.WriteLine("Bad Luck.");
}
Console.ReadKey();


















