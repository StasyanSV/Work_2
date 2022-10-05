﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите любое трехзначное число: ");
int number_1 = int.Parse(Console.ReadLine());
if ((number_1 > 99 && number_1 < 1000) || (number_1 < -99 && number_1 > -1000))
{
    int number_2 = number_1 % 100;
    number_2 = Math.Abs(number_2 / 10);
    Console.Write($"Введенное число {number_1} -> вторая цифра числа: {number_2}");
}
else
{
    Console.Write($"Введенные данные не соответсвуют условию задачи. Пожалуйста введите корректные данные!");
}