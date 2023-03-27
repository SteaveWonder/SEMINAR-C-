/*
int number1 = 5;
double number2 = 12.65;

string word = "my word!";
char symbol = 't';

bool check = true;
bool check = false;


int num = 5;
Console.WriteLine(num);

int num = 6;
Console.WriteLine("My number is " + num);

int num1 = 5;
int num2 = 6;
Console.WriteLine("My number are " + num1 + " and " + num2 + " it's good! ");
Console.WriteLine($"My number are {num1} and {num2} it is good!");

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number: " + num);


// HomeWork 1.

// Task 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if (num1 == quad2)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}


// Task 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N. (Цикл)

Console.Write("Input positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}


32145 / 10 = 3214
32145 / 100 = 321
32145 / 1000 = 32
32145 / 10000 = 3

32145 % 10 = 5
32145 % 100 = 45
32145 % 1000 = 145
32145 % 10000 = 2145

72635 -> 26
*/
