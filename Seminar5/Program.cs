//Task 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных элементов массива.

// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;    
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//          Console.Write(array[i] + " ");

//     Console.WriteLine();     
// }

// int GetNegativeSum(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0)
//             sum += array[i]; // то же самое, что и sum = sum + array[i];
//     }
//     return sum;
// }


// Console.Write("Input size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreatRandomArray(size, min, max);
// ShowArray(newArray);

// int result = GetNegativeSum(newArray);
// Console.Write("Sum of negative element is " + result);




//Task 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int[] ReNum(int[] array)
// {
//     for (int i = 0; i < array.Length; i++) array[i] = array[i] * (-1);
//     return array;
// }


//Task 3. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// bool Num(int[] array, int num)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == num)
//         return true;
//     }
//     return false;
// }

//Task 4. Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

// int[] CreatRandomArray(int size, int a, int b)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(a, b + 1);
//     return array;    
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//          Console.Write(array[i] + " ");

//     Console.WriteLine();     
// }
// int NumArray(int[] array, int a, int b)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= a && array[i] <= b)
//             sum++;
//     }
//     return sum;
// }
// int[] newArray = CreatRandomArray(10, 1, 100);
// ShowArray(newArray);
// Console.Write(NumArray(newArray, 10, 40));


//Task 5.Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.