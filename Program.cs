// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

//Console.WriteLine("Hello, now we will learn variable types");

//int a= 5;
//double af = 3.14;

//int b = 11;
//double bf = 5.55;

//int c = a + b;
//double cf = af + bf;

//Console.WriteLine(c);
//Console.WriteLine(cf);

//var number1 = 15.85;
//var number2 = 10.12;
//var answer = number1 * number2;
//Console.WriteLine(answer);

//var someText = "This is a text.";
//Console.WriteLine(someText);

void SendGreetings()
{
    Console.WriteLine("Ciao!");
}

void GreetPerson(string name)
{
    Console.WriteLine($"Hello {name}!");
}

GreetPerson("Anna");

int SumTwoIntegers(int a, int b)
{
    return a + b;
}

Console.WriteLine(SumTwoIntegers(5, 6));

double SumTwoFloatingNumbers(double a, double b)
{
    return a + b;
}

Console.WriteLine(SumTwoFloatingNumbers(3.14, 5.55));

string UniteTwoStrings(string a, string b)
{
    return a + b;
}