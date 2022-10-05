// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любое целое число: ");
int number_1 = int.Parse(Console.ReadLine());

if (number_1 > 99 || number_1 < -99)
{
    number_1 = Math.Abs(number_1);

    //Подсчет колличества цифр в введенном числе
    int x = number_1, counter = 0;
    while (x > 0)
    {
        x = x / 10;
        counter++;
    }
    //Console.WriteLine($"Цифр в числе: {counter}");

    //Деление на 10 в степени "{counter}-3". Деление числа до третьей цифры
    int number_2 = number_1;
    while (counter-3 > 0)
    {
        number_2 = number_2 / 10;
        counter--;
    }
    //Console.WriteLine($"Полученное число: {number_2}");

    //Вычисление третьей цифры
    number_2 = number_2 % 10;

    Console.Write($"Введенное число: {number_1} -> третья цифра: {number_2} ");
}
else
{
    Console.Write($"Введенное число: {number_1} -> третьей цифра: нет.");
}