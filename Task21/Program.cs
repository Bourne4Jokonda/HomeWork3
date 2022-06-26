﻿// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату по Х для точки A : ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату по У для точки A : ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату по Z для точки A : ");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату по Х для точки B : ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату по У для точки B : ");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату по Z для точки B : ");
double z2 = double.Parse(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"расстояние между точками A и B {distance}");
