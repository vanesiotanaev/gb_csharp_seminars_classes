// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int NumberOfDigitsMethod (int number)
{
   int digit = 0;
   while (number != 0)
   {
        number = number / 10;
        digit++;
   }
   return digit;    
}

//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int sum(int A)
{
    int count = 0;
    for(int i = 1; i <= A; i++) count = count + i;
    return count;
}

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N, кратных трем.

int Multiply(int N)
{
    int multi = 1;
    int i = 1;
    while(i <= N) 
    {
        if(i % 3 == 0) multi = multi * i;
        i++;
    }
    return multi;
}

//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] GenerateRandomArrayMethod(int size, int minValue, int maxValue)
{
   int[] newArray = new int[size];
   for (int i = 0; i < size; i++)
   {
      newArray[i] = new Random().Next(minValue, maxValue + 1);
   }
   return newArray;
}

void ShowArrayMethod(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");

   Console.WriteLine();
}

Console.Write("Please, enter the number: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
int usernumdigit = NumberOfDigitsMethod(usernumber);
Console.WriteLine("The number " + usernumber + " is a " + usernumdigit + "-digit number!");

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = sum(num);
Console.WriteLine($"Sum = {res}");

Console.Write("Input number: ");
int multnum = Convert.ToInt32(Console.ReadLine());
int multres = Multiply(multnum);
Console.WriteLine($"Multi = {multres}");

int[] binaryArray = GenerateRandomArrayMethod(8, 0, 1);
ShowArrayMethod(binaryArray);
