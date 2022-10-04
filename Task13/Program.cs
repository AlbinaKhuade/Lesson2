// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number; // используем временную переменную, чтобы в результате вывести изначально введенное число

if (temp > 99) // добавить temp < -99 если не только для положительных чисел - но все равно неверно ?????????????
{
    while (temp > 1000)
    {
        temp = temp / 10;
    }
int thirdDigit = temp % 10;
Console.WriteLine($"{number} -> {thirdDigit}");
}
else Console.WriteLine("Третьей цифры нет");



// int SecondDigit(int num)
// {
//     int firstDigit = num % 100;
//     int thirdDigit = num % 10;
//     return (firstDigit - thirdDigit)/10;  // метод возращает результат вычисления

// }

// int result = SecondDigit(number);
// Console.WriteLine($"{number} -> {result}");