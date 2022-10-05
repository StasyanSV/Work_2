// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7, где число обозначает день недели соотвественно: ");
int number_1 = int.Parse(Console.ReadLine());

switch (number_1)
{
    case 1:
        Console.WriteLine($"Вы ввели число {number_1} - Понедельник -> рабочий день.");
        break;
    case 2:
        Console.WriteLine($"Вы ввели число {number_1} - Вторник -> рабочий день.");
        break;
    case 3:
        Console.WriteLine($"Вы ввели число {number_1} - Среда -> рабочий день.");
        break;
    case 4:
        Console.WriteLine($"Вы ввели число {number_1} - Четверг -> рабочий день.");
        break;
    case 5:
        Console.WriteLine($"Вы ввели число {number_1} - Пятница -> рабочий день.");
        break;
    case 6:
        Console.WriteLine($"Вы ввели число {number_1} - Суббота -> выходной день.");
        break;
    case 7:
        Console.WriteLine($"Вы ввели число {number_1} - Суббота -> выходной день.");
        break;
    default:
        Console.WriteLine($"Вы ввели число {number_1} не соответсвующее условию задачи.");
        break;
}