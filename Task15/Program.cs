﻿// Задача 15: Напишите программу, которая:
// принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// Например:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number == 6 || number == 7) Console.WriteLine("да");
// else if (number>0 && number<6) Console.WriteLine("нет");
// else Console.WriteLine("Такого дня недели не существует");


bool Weekend(int num)
{
    if (num == 6 || number == 7) return true;
    else return false;
}

if (number < 1 || number > 7) Console.WriteLine("Такого дня недели не существует");
else
{
    bool res = Weekend(number);
    if (res == true) Console.WriteLine("да");
    else Console.WriteLine("нет");
}