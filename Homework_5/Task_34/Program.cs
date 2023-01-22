//  Напишите программу реализующую методы формирования массива,
// заполненного случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using static System.Console;
Clear();

int[] Array = GetArr(size: 4, Length: 3, Positive: true);

PrintArray(Array);

WriteLine($"Количество четных чисел в массиве равно {Count(Array)}");


int Count(int[] InArr, bool Even = true)
{
    int result = 0;
    if (Even)
    {
        foreach (int element in InArr)
        {
            result += element % 2 == 0 ? 1 : 0;
        }
    }
    else
    {
        foreach (int element in InArr)
        {
            result += Math.Abs(element % 2) == 1 ? 1 : 0;
        }
    }
    return result;
}



int[] GetArr(uint size, uint Length = 1, bool Positive = true)
{
    

    int[] result = new int[size];
    Random rnd = new Random();
    int BeginRand = Convert.ToInt32(Math.Pow(10, Convert.ToDouble(Length - 1)));
    int EndRand = Convert.ToInt32(Math.Pow(10, Convert.ToDouble(Length)) - 1);
    for (int i = 0; i < size; i++)
    {
        if (!Positive && rnd.Next(0, 2) == 1)
        {
            result[i] = -1 * rnd.Next(BeginRand, EndRand);
        }
        else
        {
            result[i] = rnd.Next(BeginRand, EndRand);
        }
    }

    return result;
}


void PrintArray(int[] arr)
{
    Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{arr[i]}, ");
    }
    Write($"{arr[arr.Length - 1]}]");
    WriteLine();
}