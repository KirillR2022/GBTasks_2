//Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B с использованием цикла.
//В задаче не использвать стандартный метод Pow!
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

using static System.Console;

int A = int.Parse(ReadLine()!);
int B = int.Parse(ReadLine()!);

WriteLine(($"{A} to the power {B} = {SquareNumber(A,B)}"));


int SquareNumber(int A, int B)
{
    int result = 1;
    for (int i=1; i <= B; i++)
    {
        result *= A;

    }


    return result;

}


