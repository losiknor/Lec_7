// Найти факториал числа
// 1 способ без рекурсии
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

// 2 способ с рекурсией
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n-1);
}

Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));