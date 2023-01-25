// //Задача 43: Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1,
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 


using static System.Console;
Clear();

double b1 = CheckInput("Введите значение b1: ");
double k1 = CheckInput("Введите значение k1: ");
double b2 = CheckInput("Введите значение b2: ");
double k2 = CheckInput("Введите значение k2: ");

if (k1 == k2)
{
    WriteLine("Нет решений");
}
else
{
    double x = (b2-b1) / (k1 - k2);
    double y = (k1 * (b2-b1))/ (k1-k2) + b1;
    WriteLine($"Точкой пересечения двух прямых является: x={x}, y={y}");
}


double CheckInput(string message)
{
    Write(message);
    if (!double.TryParse(ReadLine(), out double result))
    {
        WriteLine("Неверный формат ввода");
        Environment.Exit(0);
    }

    return result;

}