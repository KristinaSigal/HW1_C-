﻿// Задача 17. Напишите программу, которая 
// 1. принимает на вход координаты точки (X и Y), 
//    причём X ≠ 0 и Y ≠ 0 и
// 2. выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine()); //ReadLine - возвращает строку, Convert.ToInt32 - конвертирует в число
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0) Console.WriteLine("Четвёртая четверть");
// else Console.WriteLine("Введены некорректные координаты");

string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return("Первая четверть");
    if (xc < 0 && yc > 0) return("Вторая четверть");
    if (xc < 0 && yc < 0) return("Третья четверть");
    if (xc > 0 && yc < 0) return("Четвёртая четверть");
    return("Введены некорректные координаты");
}

string result =Quarter(x, y);
System.Console.WriteLine(result);