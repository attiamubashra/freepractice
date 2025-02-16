using FreePractice.Learning;
using Microsoft.Win32.SafeHandles;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Diagnostics.SymbolStore;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

// Personal
//FreePractice.Personal.LessonOne pLessonOne = new FreePractice.Personal.LessonOne();
//pLessonOne.ExcerciseOne();

// Learning
// LessonFour.PrintMessage();

// calling the  method and using the argument as integers.
// int sum = LessonFour.AddNumbers(3, 4);
// Console.WriteLine(" The REsult of two inegers is "+ sum);

// float product = LessonFour.Multiply(2.2f ,2.4f);
// Console.WriteLine("The Product of two floatin points is "+ product);

// LessonFour.FindMax(23, 45);

// int mysquare = LessonFour.Square(4);
// Console.WriteLine("square: "+mysquare);

//Console.ReadKey();

//

// Udemy
//FreePractice.Udemy.SectionThree sectionThree = new FreePractice.Udemy.SectionThree();
//sectionThree.BoiledEgg();


//FreePractice.Learning.LessonOne lessonOne = new FreePractice.Learning.LessonOne();
//lessonOne.ExcerciseOne();

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

/*Console.WriteLine("Enter a number.");
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


//////................*********...............\\\\\\\\
Console.WriteLine("Write down your lucky number.");
string numberR = Console.ReadLine();

int luckyNumber;
bool luckyDrawNumber = int.TryParse(numberR, out luckyNumber);

if (luckyDrawNumber)
{
    Console.WriteLine("Your number has enterd in lucky Draw.");
}
else 
{
    Console.WriteLine("Try again {0} is not registered.",numberR);
}
Console.ReadKey();*/


/////////.............*********............\\\\\\\\\\\

// for loop practice.
// for (int i> 0;i<5 ; i++ )



//string rocket = "   /\\ \n   / \\\n  /   \\\n||     ||\n||     ||\n||     ||\n-------";
//for (int i=3; i >= 0 ;i-- ) 
//    {
//    Console.Clear();
//    Console.WriteLine(i);
//    Console.WriteLine(rocket);
//    Thread.Sleep(1000);
//}

//Console.ReadKey();

///////........**********.........\\\\\\\\\\\
/////// While loop 
//int secretNumber = 23;
//int userGuess = 0;


//Console.WriteLine("Guess the number.");

//while (userGuess != secretNumber)
//{

//    Console.WriteLine("Enter your Guess.");
//      userGuess = int.Parse(Console.ReadLine());
//    if (userGuess < secretNumber)
//    {
//        Console.WriteLine("Number is too low.Try again.");
//    }
//    else if (userGuess > secretNumber)
//    {
//        Console.WriteLine("Number is too high.Try again.");
//    }
//    else 
//    {
//        Console.WriteLine("Congratulations;number is right.");
//    }

//    Console.ReadKey();


//}

///////////.................\\\\\\\\\\\\\
//int myNumber = 45;
//int userNumber = 0;
//int counter = 0;
//Console.WriteLine(" lucky number.");

//while (userNumber != myNumber)
//{
//    counter++;
//    Console.WriteLine("Enter your lucky number.");
//    userNumber = int.Parse(Console.ReadLine());
//    if (userNumber < myNumber)
//    {
//        Console.WriteLine(" Wrong number.");

//    }
//    else if (userNumber > myNumber)
//    {
//        Console.WriteLine("Not True Number.");
//    }
//    else
//    {
//        Console.WriteLine("You got right number.");
//         Console.WriteLine("You tried "+ counter +" times."); 

//    }
//}
//Console.ReadKey();
/////////...........*******.........\\\\\\\\\
// for loop incrcreasing 
// for (int i=0; i<8 ; i++)

//for (int i = 0; i<15;    i++   )
//{
//    Console.WriteLine("the data contains " + i);
//}
//Console.ReadKey();
//////////.........********.........\\\\\\\\\\\\
//// for loop 
//// time lapes
//// clear line.

//for (int timer = 0; timer <11; timer++)
//{
//    Console.Clear();
//    Console.WriteLine("The timer for egg boil working "+ timer);
//    Thread.Sleep(1000);

///////............*********.........\\\\\\\\\
// for loop 
// decrease
// time lapse

//for (int decrease = 15; decrease>= 0; decrease--)
//{
//    Console.Clear();
//    Console.WriteLine("The Values are {0}", decrease);
//    Thread.Sleep(300);
//}
/////////.......*******......\\\\\
//// while loop.
//// use as counter.

//int a = 0;
//while (a<15) 
//{
//    Console.WriteLine(a);
//    a++;
//}
//Console.ReadKey();

///////......*******.....\\\\\
////while for decrement loop
//int b =  15;
//while (b>=0) 
//{
//    Console.Clear();
//    Console.WriteLine(b);
//    b--;
//    Thread.Sleep(1000);
//}
//////......*****......\\\\\
// while usage
// guess the number.

Console.WriteLine("Enter a whole number.");
int i = int.Parse(Console.ReadLine());


//int integer= IsEven(i);


//    if (i %2 ==0)
//    {
//        Console.WriteLine("True");
//    }
//    else
//    {
//        Console.WriteLine("False");
//    }

//    return;


//    Console.ReadKey();
//////......*****.......\\\\\\\
///8. Concatenate Strings
/*Write a method Concatenate that accepts two string parameters and returns their
concatenated result.*/


string Concatination(string s1 ,string s2)
{
    string result = s1 +s2;
    return result;
}

string w1 = " Good mornings,";
 string w2 ="today is sunday.";

// calling the method and using the arguments.
   Concatination(w1,w2);

Console.ReadKey();

//////........******.........\\\\\\
/// 7. Convert Celsius to Fahrenheit
/*Create a method ConvertToFahrenheit that accepts a temperature in Celsius and returns the
equivalent in Fahrenheit.*/
double ConvertToFahrenheit(double degrees)
{
    double conversionDegree = (degrees *1.8)+32;
    return conversionDegree;
}
Console.WriteLine("Enter your city temperature in degree celcius.");

double celciusDegree = double.Parse (Console.ReadLine());

//Calling the method using argument .
ConvertToFahrenheit(celciusDegree);

Console.ReadKey();
/////////........*******........\\\\\\\\
///9. Calculate Area of a Rectangle

/*Write a method RectangleArea that takes two parameters: length and width, and returns the
area of the rectangle.*/

double RectangleArea(double length, double width)
{
    double area = length * width;
    return area;
    Console.WriteLine("The calculated area of rectangle is "+ area);
}
RectangleArea(12.0, 34.5);


Console.ReadKey();
//////.........******........\\\\\\
/*10.Generate a Greeting Message
Write a method Greet that takes a string parameter for a name and returns a greeting
message like &quot; Hello, [name]!&quot;*/

string Greet(string greeting) 

{
    string message = greeting;
    return message;
}
Console.WriteLine("Enter yur name.");

string name = Console.ReadLine();


//Calling the method passing the argument .

Greet("\"Hello"+ name+" !\"");


Console.ReadKey();

//////////.......*******......\\\\\\
///11. Calculate Factorial
/*Write a method Factorial that takes an integer parameter and returns the factorial of the
number.*/

int Factorial(int i) 
{
    
    for (; i>= 1; i--) 
    {
        Console.WriteLine(i);
    }
    return i;
}

Console.WriteLine("Write an integer to find out its factorial.");
int num = int.Parse( Console.ReadLine());

//int i = num;
//calling the method by passing the argument.
Factorial(num);

Console.ReadKey();
////////,.......******.........\\\\\\\\\
///12. Find Average of Three Numbers
/*Create a method Average that takes three double parameters and returns the average.*/

double Average(double r1 ,double r2 ,double r3) 
{
    double average = (r1+ r2 + r3)/3;
    return average;
}
Console.WriteLine("Write any decimal number.");
double r1Number = double.Parse(Console.ReadLine());

//calling the method by pssing the arguments.
Average(r1Number, 12, 13);

Console.ReadLine();

////////........********............\\\\\\\\
///13. Convert Integer to String
/*Write a method IntToString that takes an integer parameter and returns its string
representation.*/

string IntToString (int word)
{
    string representation = Convert.ToString(word);
    return representation;
}
IntToString(13);

Console.ReadKey();
/////////////............********..........\\\\\\\\\\\\\
bool IsEligibleToVote(int age)
{
    if (age >= 18)
        return true;
    else
        return false;
}

 bool notEligible = IsEligibleToVote(12);
 bool eligible = IsEligibleToVote(23);
//////////.........******..........\\\\\\\\\
///19. Calculate Compound Interest
//Write a method CompoundInterest that takes principal amount, rate of interest, time (in
//years), and number of times interest applied per year as parameters, and returns the
//compound interest.
