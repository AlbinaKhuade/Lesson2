// Задача 10: Напишите программу, которая:
//принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    int firstDigit = num % 100;
    int thirdDigit = num % 10;
    return (firstDigit - thirdDigit)/10;  // метод возращает результат вычисления

}

int result = SecondDigit(number);
Console.WriteLine($"{number} -> {result}");
