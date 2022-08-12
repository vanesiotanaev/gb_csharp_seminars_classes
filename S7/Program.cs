// Двумерный массив. 
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}   

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2DArray(r, c, min, max);
Show2DArray(array);


//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.\

int[,] CreateRandom2DArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = i + j;
        }
    }

    return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2DArray(r, c);
Show2DArray(array);

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
} 

int[,] EvenArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i = i + 2)
    {
        for(int j = 0; j < array.GetLength(1); j = j + 2)
        {
            array[i,j] *= array[i,j];
        }
    }

    return array;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] userArray = CreateRandom2DArray(r, c, min, max);
Show2DArray(userArray);
int[,] changeArray = EvenArray(userArray);
Show2DArray(changeArray);

*/

//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}   

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumMethod(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j) sum = sum + array[i, j];
        }
    }

    return sum;
}

Console.Write("Input number of rows: ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] userArray = CreateRandom2DArray(r, c, min, max);
Show2DArray(userArray);
int result = SumMethod(userArray);
Console.WriteLine($"Сумма элементов на главной диагонали равна: {result}");