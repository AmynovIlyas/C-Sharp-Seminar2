// Напишите программу, которая выводит случайное (рандомное) число из отрезка [10; 99] и показывает наибольшую цифру числа
// Например:
// 78 --> 8
// 12 --> 3
// 85 --> 8

void FindMost(int rand)
{
    int a = rand / 10;
    int b = rand % 10;
    int max = a;
    if (b > a)
    {
        max = b;
    }
    Console.WriteLine(max);
}

int rand = new Random().Next(10, 100);
Console.WriteLine(rand); 
FindMost(rand);


// Решение без метода:
// Console.WriteLine("Рандомное число: " + rand);
// int a = rand / 10;
// int b = rand % 10;
// if (a > b)
// {
//     Console.WriteLine("Наибольшая цифра числа: " + a);
// }
// else if (a == b)
// {
//     Console.WriteLine("Введённое число состоит из одинаковых цифр");
// }
// else
// {
//     Console.WriteLine("Наименьшая цифра числа: " + b);
// }