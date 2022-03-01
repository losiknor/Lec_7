// Вычислить a в степени n
// 1 способ без рекурсии
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

// 2 способ с рекурсией
int PowerRec(int a, int n)
{
    if (n== 0) return 1;
    else return PowerRec(a, n-1) * a;
}

// 3 способ - как 2, но короче записано
int PowerRec1(int a, int n)
{
    return n == 0 ? 1 : PowerRec1(a, n-1) * a; 
}
Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRec1(2, 10));

// 4 способ - делим степень пополам - уменьшаем количество итераций
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n-1) * a;
}
Console.WriteLine(PowerRecMath(2, 9));