// Напишите программу реализующую методы формирования массива, заполненного случайными
// числами и подсчета суммы элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

int[] GeneratedArray = RandArray(4);
PrintArray(GeneratedArray);
WriteLine($" Сумма нечетных элементов равна {Count(GeneratedArray)}");

int Count(int[] InArray, bool Even = true)
{
    int Summ = 0;
    for (int i = Even ? 1 : 0; i < InArray.Length; i += 2)
    {
        Summ += InArray[i];
    }
    return Summ;
}

int[] RandArray(uint size, int BeginRand = 0, int EndRand = 9)
{
   

    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(BeginRand, EndRand + 1);
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