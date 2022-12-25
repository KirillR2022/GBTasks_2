//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using static System.Console;
WriteLine("Введите пятизначное число");
int number = int.Parse(ReadLine()!);
int a = number / 10000;
int b = number / 1000 % 10;
int c = number % 10;
int d = number  / 10 % 10;
if (a == c && b == d) WriteLine("Да");
else WriteLine("Нет");