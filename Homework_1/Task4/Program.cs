using static System.Console;

int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
int c = int.Parse(ReadLine()!);

if (a > b && a > c)
{
    Write($"{a}");
}
if (b > a && b > c)
{
    Write($"{b}");
}
else
{
    Write($"{c}");
}