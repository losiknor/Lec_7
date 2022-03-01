// Сумма чисел от 1 до n
// 1 способ без рекурсии
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

// 2 способ с рекурсией
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n-1);
}
Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));