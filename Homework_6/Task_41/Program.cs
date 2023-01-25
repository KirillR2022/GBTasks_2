// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();

WriteLine("Введите числа"); 
string[] InputArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine($"Пользователь ввел {CountPositives(InputArray)} чисел больше 0");  
int CountPositives(string[] InArr)
{
       double temp = 0;
    int count = 0;
    for (int i = 0; i < InArr.Length; i++)
    {
        if (!double.TryParse((InArr[i]), out temp));
        
        else
        {
            count += temp > 0 ? 1 : 0;
        }
    }

    double[] ArrayDoubel = new double[InArr.Length];
    return count;
}