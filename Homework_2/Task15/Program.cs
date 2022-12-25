// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

using static System.Console;
WriteLine("Введите число от 1 до 7");
int number = int.Parse(ReadLine()!);
if (number >=1 && number <=5) WriteLine("Нет");
if (number >=6 && number <=7) WriteLine("Да");
