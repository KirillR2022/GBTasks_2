//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using static System.Console;
int number = int.Parse(ReadLine()!);
int a = number/100;
a = a % 10;
if (number < 100) WriteLine("Третьей цифры нет");
else Write(a);