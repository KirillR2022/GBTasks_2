//  Напишите программу реализующую методы формирования массива, заполненного случайными
//  вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.
//[3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;
Clear();

double[] GeneratedArray = GenerateArray(8);
PrintDoubleArray(GeneratedArray, 2);
WriteLine($"разница между максимальным и минимальным элементом массива равна {MinMaxDifr(GeneratedArray, 2)}");

double MinMaxDifr(double[] InnArr, uint round = 4)
{
    double max = InnArr[0];
    double min = InnArr[0];

    for (int i = 0; i < InnArr.Length; i++)
    {
        max = InnArr[i] > max ? InnArr[i] : max;
        min = InnArr[i] < min ? InnArr[i] : min;
    }

    return Math.Round(max - min, Convert.ToInt32(round));
}

double[] GenerateArray(uint size, double BeginArr = 0, double EndArr = 10)
{
    
    double[] result = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = BeginArr + rnd.NextDouble() * (EndArr - BeginArr);
    }
    return result;
}
void PrintDoubleArray(double[] arr, uint round = 4)
{
    Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{Math.Round(arr[i], Convert.ToInt32(round))}, ");
    }
    Write($"{Math.Round(arr[arr.Length - 1], Convert.ToInt32(round))}]");
    WriteLine();
}