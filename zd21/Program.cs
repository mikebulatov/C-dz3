﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 21. Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

Console.WriteLine("Введите  кординаты 1й точки:");
Console.Write(" x1=");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" y1=");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" z1=");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите  кординаты 2й точки:");
Console.Write(" x2=");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write(" y2=");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write(" z2=");
int z2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Расстояние между ними в 3D пространстве:"+Convert.ToString(Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5)));