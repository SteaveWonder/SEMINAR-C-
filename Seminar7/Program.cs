//Task 1.Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] CreateRandomArray()
{
    Console.Write("Input quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }        
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             Console.Write(array[i,j] + " ");
        }     
        Console.WriteLine();
    }         
    Console.WriteLine();
}

int[,] myArray = CreateRandomArray();
Show2dArray(myArray);




//Task 2.Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран. FIX!!!

int[,] Array2d(int[,] array, int m, int n)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
             Console.Write(array[i,j] + " ");
        Console.WriteLine();     
    Console.WriteLine();
} 
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
int[,] newArray = Array2d[array, m, n];
Show2dArray(newArray);


//Task 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateRandomArray()
{
    Console.Write("Input quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void FindEvent(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                array[i,j] *= array[i,j];
            }
        }
    }
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
             Console.Write(array[i,j] + " ");
        Console.WriteLine();     
    Console.WriteLine();
} 
int[,] newArray = CreateRandomArray();
Show2dArray(newArray);
FindEvent(newArray);
Show2dArray(newArray);

*/




//Task 4.Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] CreateRandomArray()
{
    Console.Write("Input quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
int FindDiagSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i ==j)
            {
                sum += array[i,j];
            }
        }
    }
    return sum;
}

int[,] newArr = CreateRandomArray();
Console.WriteLine(FindDiagSum(newArr));