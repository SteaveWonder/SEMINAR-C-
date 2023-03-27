// Task 1
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int hundreds = num / 100;
//     int units = num % 10;

//     int result = hundreds * 10 + units;
//     return result;
// }

// int randNumber = new Random().Next(100, 1000);
// int newNumber = CutNumber(randNumber);

// Console.WriteLine($" New version of {randNumber} is {newNumber} ");

// Task 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int MaxNumber(int num)
// {
//     int tens = num / 10;
//     int units = num % 10;
//     int max = 0;
//     if (tens > units)
//     {
//         max = tens;
//     }
//     else
//     {
//         max = units;
//     }
//     return max;
// }

// int randNumber = new Random().Next(10, 100);
// int newNumber = MaxNumber(randNumber);
// Console.WriteLine($" Largest digit of number {randNumber} is {newNumber} ");


// Task 3. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

// bool ModNumber(int num, int a, int b)
// {
//     if(num % a == 0 && num % b == 0 )
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// Console.WriteLine("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Input number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(ModNumber(num, a, b));



// Task 4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// bool Numbers(int a, int b)
// {
//     if(a == b * b || b == a * a)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// Console.Write("Input number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Numbers(a, b));

