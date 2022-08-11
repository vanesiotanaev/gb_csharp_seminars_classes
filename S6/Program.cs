/*

//1. Написать программу, которая перевернет массив.

int[] GenerateRandomArrayMethod(int size, int minValue, int maxValue)
{
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++) newArr[i] = new Random().Next(minValue, maxValue + 1);
    return newArr;
}

void ShowArrayMethod(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");
   Console.WriteLine();
}

int[] ReverseArrayMethod(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    return array;
}

//double numb = new Random().Next(1, 10) + new Random().NextDouble();
//В строке 29 гененрируем вещественное число - отдельно его целую часть, отдельно дробную.

//Random rand = new Random();
//double numb = rand.Next(1, 10) + rand.NextDouble();
//Сделали то же самое, только через объект -- Random.
//Создали "рандомовскую переменную".

// Программа, принимающая на вход три числа, определяющая, может ли существовать треугольник со сторонами такой длины.

bool TriangleExist (int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} существует!");
        return true;
    }
    else
    {
        Console.WriteLine($"Треугольникa со сторонами {a}, {b} и {c} не существует!");
        return false;
    }   
}

Console.Write("Введите длину стороны a: ");
int userA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны b: ");
int userB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны c: ");
int userC = Convert.ToInt32(Console.ReadLine());

bool exist = TriangleExist(userA, userB, userC);

// Программа на вход берет число, возвращает двоичное представление. 

string Decimal2Binary (int number)
{
    string binary = "";
    int modulo = 0;
    if (number != 0)
    {
        while (number > 1 || number < -1)
        {
            modulo = number % 2;
            number = number / 2;
            binary = binary + modulo;
        }
        binary = binary + "1";
        char[] chars = binary.ToCharArray();
        Array.Reverse(chars);
        binary = new string(chars);
    }
    else binary = "0";

    return binary;
}

Console.Write("Введите десятичное число: ");
int userdec = Convert.ToInt32(Console.ReadLine());
string result = Decimal2Binary(userdec);

Console.WriteLine($"Двоичное пресдтавление десятичного числа {userdec} выглядит так: {result}");

*/

// Не используя рекурсию, выведите первые n чисел Фибоначчи. Пусть первые два числа будут аргументами на вход метода.

int[] Fibonacci(int n, int a, int b)
{
    int[] array = new int[n];
    array[0] = a;
    Console.WriteLine(array[0]);
    array[1] = b;
    Console.WriteLine(array[1]);
    for(int i = 2; i < n; i++)
    {
        array[i] = array[i-1] + array[i-2];
        Console.WriteLine(array[i]);
    }

    return array;
}

Console.Write("Введите N: ");
int userN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите A: ");
int userA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int userB = Convert.ToInt32(Console.ReadLine());

Fibonacci(userN, userA, userB);