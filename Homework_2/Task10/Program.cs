//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using static System.Console;
int number = int.Parse(ReadLine()!);
int a = number/10;
Write(a%10);
