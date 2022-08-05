//05.08.2022 Seminar 5.

//1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int[] CreateArray(int size)
{
    int[] newarray = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} element of {size}: ");
        newarray[i] = Convert.ToInt32(Console.ReadLine());
    }

    return newarray;
}  

void ShowArrayMethod(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");

   Console.WriteLine();
}

int SumPositiveMethod(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) sum +=array[i];

    return sum;
}

//Можно доработать с методом GenerateRandomArray из предыдущего семинара.

//2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*int[] CreateRandomArray(int size, int minValue, int maxValue) // Метод Генерация рандомного массива
{
    int[] newArray = new int[size]; //Выделение памяти под массив (запомнить!!!!!)

    for(int i = 0; i < size; i++) newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[] array) // Вывод массива
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) array[i] *= -1;
    return array;
}

int[] NewArray = CreateRandomArray(7, -11, 9);
ShowArray(NewArray);
int[] RevArray = ReverseArray(NewArray);
ShowArray(RevArray);
*/

//3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue) // Метод Генерация рандомного массива
{
    int[] newArray = new int[size]; //Выделение памяти под массив (запомнить!!!!!)

    for(int i = 0; i < size; i++) newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[] array) // Вывод массива
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");

    Console.WriteLine();
}

bool FindNumber(int[] array, int num)
{
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num) return true;
    }
    return false;
}


Console.Write("ВВедите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] NewArray = CreateRandomArray(7, -11, 9);
ShowArray(NewArray);


bool n = FindNumber(NewArray, number);
Console.WriteLine(n);
*/
//4. Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] CreateRandomArray(int size, int minValue, int maxValue) // Метод Генерация рандомного массива
{
    int[] newArray = new int[size]; //Выделение памяти под массив (запомнить!!!!!)

    for(int i = 0; i < size; i++) newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[] array) // Вывод массива
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");

    Console.WriteLine();
}

int Count(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}

int[] NewArray = CreateRandomArray(12, -200, 573);
ShowArray(NewArray);

int c = Count(NewArray);
Console.WriteLine($"Количество элементов в отрезке [10, 99] = {c}");

//5. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21