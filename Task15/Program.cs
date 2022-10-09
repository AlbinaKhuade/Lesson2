// Задача 15: Напишите программу, которая:
// принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// Например:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Weekend(int num)
{
    return (num == 6 || number == 7);
}

if (number < 1 || number > 7) Console.WriteLine("Такого дня недели не существует");
else
{
    bool res = Weekend(number);
    if (res == true) Console.WriteLine("да");
    else Console.WriteLine("нет");
}