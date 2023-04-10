//Task 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)


// void ReverseArray(int[] array)
// {
//     for(int left = 0, right = array.Length - 1; left < right; left++, right--)
//     {
//         int temp = array[left];
//         array[left] = array[right];
//         array[right] = temp;
//     }
// }

// int[] myArray = {1, 2, 3, 4, 5};
// ReverseArray(myArray);

// for(int i = 0; i < myArray.Length; i++)
//     Console.Write(myArray[i] + " ");




//Task 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// bool Tri(int a, int b, int c)
// {
//     if (a + b > c && b + c > a && a + c > b)
//     return true;
//     else return false; 
// }
// Console.Write("input a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("input b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("input c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Tri(a,b,c));




//Task 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// int[] Fib(int a, int b, int n)
// {
//     int[] array = new int[n];
//     array[0] = a;
//     array[1] = b;
//     for(int i = 2; i < n; i++)
//         array[i] = array[i - 1] + array[i - 2];
//     return array;    
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// Console.Write("input a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("input b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("input size: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] myArray = Fib(a,b,n);
// ShowArray(myArray);




//Task 4. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] CopyArray(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for(int i = 0; i < array.Length; i++)
//     newArray[i] = array[i];
//     return newArray;
// }





//Task 5. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// s = n % 2 + s
// n = n//2

// string ConvertToByte(int n)
// {
//     string s = string.Empty;
//     while (n >= 2)
//     {
//         s = n % 2 + s;
//         n = n/2;
//     }
//     s = n + s;
//     return s;
// }
// Console.Write("input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(ConvertToByte(n));
