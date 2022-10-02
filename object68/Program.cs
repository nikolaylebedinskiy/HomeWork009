//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int AkkermanFunction(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    if (M != 0 && N == 0)
    {
        return AkkermanFunction(M - 1, 1);
    }
    if (M > 0 && N > 0)
    {
        return AkkermanFunction(M - 1, AkkermanFunction(M, N - 1));
    }
    return AkkermanFunction(M, N);
}

int M = Promt("Введите число: ");
int N = Promt("Введите число: ");
Console.WriteLine($"Функция Аккермана для чисел ({M},{N}) = {AkkermanFunction(M, N)}");