//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using static System.Console;
int X1 = int.Parse(ReadLine()!);
int Y1 = int.Parse(ReadLine()!);
int Z1 = int.Parse(ReadLine()!);
int X2 = int.Parse(ReadLine()!);
int Y2 = int.Parse(ReadLine()!);
int Z2 = int.Parse(ReadLine()!);

double a = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2) + Math.Pow((Z1 - Z2), 2));
WriteLine("{0:f2}",a);
