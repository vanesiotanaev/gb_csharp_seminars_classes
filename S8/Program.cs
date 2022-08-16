//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*

int[,] GenerateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
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

void Show2DArray(int[,] array)
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

int[,] ChangeRows(int[,] array)
{
    int temp = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }

    return array;
}

Console.Write("Введите количество строк массива: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение случайного элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение случайного элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = GenerateRandom2DArray(r, c, min, max);
Show2DArray(newArray);
int[,] changedArray = ChangeRows(newArray);
Show2DArray(changedArray);

//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] GenerateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
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

void Show2DArray(int[,] array)
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

int[,] Transposition(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1)) Console.WriteLine("Матрицу невозможно транспонировать, т.к. она не является квадратной!");
    else
    {
        int temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                temp = array[j, i];
                array[j, i] = array[i, j];
                array[i, j] = temp;
            }
        }
    }

    return array;
}

Console.Write("Введите количество строк массива: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение случайного элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение случайного элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = GenerateRandom2DArray(r, c, min, max);
Show2DArray(newArray);
int[,] transpArray = Transposition(newArray);
Show2DArray(transpArray);

*/

//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] GenerateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
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

void Show2DArray(int[,] array)
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

int[,] ShortenedArray(int[,] array)
{
    int elMin = array[0, 0];
    int minI = 0;
    int minJ = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] <= elMin) 
            {
                elMin = array[i, j];
                minI = i;
                minJ = j;
            }
        }
    }
    Console.WriteLine($"Минимальный элемент в данном массиве: {elMin} (индексы: {minI}, {minJ}).");
    Console.WriteLine();

    int[,] smallArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
   
    int newI = 0; 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        if (i != minI)  
        { 
            int newJ = 0; 
            for (int j = 0; j < array.GetLength(1); j++) 
            { 
                if (j != minJ) 
                { 
                    smallArray[newI, newJ] = array[i, j]; 
                    newJ++; 
                } 
            } 
            newI++; 
        } 
    }
    
    return smallArray;
}

Console.Write("Введите количество строк массива: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение случайного элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение случайного элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = GenerateRandom2DArray(r, c, min, max);
Show2DArray(newArray);
int[,] ShortArray = ShortenedArray(newArray);
Show2DArray(ShortArray);