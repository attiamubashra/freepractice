using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;


FreePractice.Learning.LessonOne lessonOne = new FreePractice.Learning.LessonOne();
lessonOne.ExcerciseOne();


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


///* ============== Excercise 3:  ============== */


///* ============== Excercise 4:  ============== */


///* ============== Excercise 5:  ============== */


///* ============== Excercise 6:  ============== */


///* ============== Excercise 7:  ============== */


///* ============== Excercise 8:  ============== */



///* ============== Excercise 9:  ============== */
//// if and else statements.
//// declaring a variable assigning it a value.
//// camelCase method.
//// string interpolation .

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
Console.ReadKey();


/////////.............*********............\\\\\\\\\\\









