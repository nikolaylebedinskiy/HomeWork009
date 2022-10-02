//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


int Promt (string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int M, int N)
{
    int sum = 0;
    if (M > N)
    {
        return 0;
    }
    sum = M + SumNumbers(M + 1, N);
    return sum;
}

int M = Promt("Введите число: ");
int N = Promt("Введите число: ");
System.Console.WriteLine($"Сумма чисел от {M} до {N} равна: {SumNumbers(M, N)}");