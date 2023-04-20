using System;
//Task 1.Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
void ChangeRows(int[,] array, int row1, int row2)
{                                                                                             // проверка что это не одна и та же строка
    if(row1  >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0) && row1 != row2)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
    else Console.WriteLine("Wrong row number!");
}

int[,] myArray = CreateRandomArray();
Show2dArray(myArray);

Console.Write("Input number of the first row for change: ");
int r1 = Convert.ToInt32(Console.ReadLine()) - 1;

Console.Write("Input number of the second row for change: ");
int r2 = Convert.ToInt32(Console.ReadLine()) - 1;

ChangeRows(myArray, r1, r2);
Show2dArray(myArray);



//Task 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

void TurnArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
}
int[,] myArray = CreateRandomArray();
Show2dArray(myArray);
TurnArray(myArray);
*/


//Task 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент. FIX!!!!!!

int[] FoundMin(int[,] array)
{
    int[] index = { 0, 0 };
    // int min = array[0, 0];
    // int rowElement = 0;
    // int columnsElement = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[index[0], index[1]])
            {
                // min = array[i, j];
                // rowElement = i;
                // columnsElement = j;
                index[0] = i;
                index[1] = j;
            }
        }
    }
    return index;
}

int[,] DeleteRowAndColumn(int[,] array, int[] index)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0, m = 0; i < array.GetLength(0); i++)
    {
        if (i != index[0])
        {
            for (int j = 0, n = 0; j < array.GetLength(1); j++)
            {
                if (j != index[1])
                {
                    newArray[m, n] = array[i, j];
                    n++;
                }
            }
            m++;
        }
    }
    return newArray;
}

int[,] myArray = CreateRandomArray();
Show2dArray(myArray);
int[,] endResult = DeleteRowAndColumn(myArray, FoundMin(myArray));
Show2dArray(endResult);