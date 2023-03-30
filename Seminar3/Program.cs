// Task 1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void ShowRange(int quadrant);
// {
//     if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
//     else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
//     else if (quadrant == 3) Console.WriteLine("x < 0 and y < 0");
//     else if (quadrant == 4) Console.WriteLine("x > 0 and y < 0");
//     else Console.WriteLine("Quadrant doesn't exist!");
// }

// Console.Write("Input number of quadrant: ");
// int quadNum = Convert.ToInt32(Console.ReadLine());
// ShowRange(quadNum);


// Task 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int Quad(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     else return -1;
// }

// Console.Write("Input X quadrant: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Y quadrant: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Quad(x, y));



// Task 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// double Length(int x1, int x2, int y1, int y2)
// {
//     double segment1 = 0;
//     double segment2 = 0;
//     segment1 = x1- x2;
//     segment2 = y1 - y2;
//     double segment3 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
//     return segment3;
// }

// Console.Write("Input x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Round(Length(x1, y1, x2, y2), 2));



// Task 4. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// void Div(int num)
// {
//     for(int i = 1; i <= num; i++)
//     Console.WriteLine($"{i} - {i * i}");
// }

// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Div(num);