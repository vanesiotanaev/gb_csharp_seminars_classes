bool IsKratno(int n1, int n2)
{
    if (n1 % n2 == 0) return true;
    else return false;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool kratno = IsKratno(num1, num2);

Console.WriteLine(kratno);