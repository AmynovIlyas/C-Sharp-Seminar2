// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа
// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8
int rand = new Random().Next(10, 100);
Console.WriteLine("Случайное число: " + rand);
int a1 = FindFirstDigitNumber(rand);
int b1 = FindSecondDigitNumber(rand);
FindMost(a1, b1);


int FindFirstDigitNumber(int r) // Пример возвращаемого метода
{
    int result = r / 10;
    return result;
}

int FindSecondDigitNumber(int r) // Пример возвращаемого метода
{
    int result = r % 10;
    return result;
}

void FindMost(int a, int b) // Пример НЕвозвращаемого метода
{
    if (a > b)
    {
        Console.WriteLine("Наибольшая цифра числа: "+ a);
    } 
    else if (a == b)
    {
        Console.WriteLine("Число состоит из одинаковых цифр");
    }
    else
    {
        Console.WriteLine("Наибольшая цифра числа: " + b);
    }
}