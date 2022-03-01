// Собрать строку с числами от a до b, a <=b
// 1 способ без рекурсии
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

// 2 способ с рекурсией
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 15));

 // 3 способ на один вызов рекурсии меньше
 string NumbersRec1(int a, int b)
{
    if (a < b) return $"{a} " + NumbersRec1(a + 1, b);
    else 
    {
        if (a == b) return $"{a} ";
        else return String.Empty;
    }
}

Console.WriteLine(NumbersRec1(1, 0));