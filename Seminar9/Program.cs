//Task 1.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// void ShowNums(int num)
// {
//     Console.Write(num + " "); 
//     if (num > 1) ShowNums(num - 1);
//     Console.Write(num + " ");
// }
// ShowNums(5);

//Task 2.Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int SumOfDigits(int num)
// {
//     if (num != 0) return SumOfDigits(num / 10) + num % 10;
//     else return 0;
// }
// Console.WriteLine(SumOfDigits(1234));
/*
f(1234) -> f(123) + 4
f(123) -> f(12) + 3
f(12) -> f(1) + 2
f(1) -> f(0) + 1
f(0) -> 0
f(1) -> 0 + 1 = 1
f(12) -> 1 + 2 = 3
f(123) -> 3 + 3 = 6
f(1234) -> 6 + 4 = 10
*/

//Task 3.Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNums(int m, int n)
{
    if (m > n)
    {
        Console.Write(m + " ");
        ShowNums(m - 1, n);
    }

    if (m < n)
    {
        ShowNums(m, n - 1);
        Console.Write(n + " ");
    }

    if (m == n)
    {
        Console.Write(n + " ");
    }
}
ShowNums(2, 15);
*/
//Task 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

// double MathFunc(int a, int b)
// {
//     if (b > 0) return MathFunc(a, b - 1) * a;

//     else if (b < 0) return MathFunc(a, b + 1) / a;

//     else return 1;
// }

// Console.WriteLine(MathFunc(2, 6));