// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
// Например:
// 456 --> 46 
// 782 --> 72
// 918 --> 98

// int rand = new Random().Next(100, 1000);
// Console.WriteLine("Случайное число: " + rand);
// DeleteSecondDigit(rand);

// void DeleteSecondDigit(int r)
// {
//     int a = rand / 100;
//     int b = rand % 100 / 10;
//     int c = rand % 100 % 10;
//     Console.WriteLine(a * 10 + c);
// }

int rand = new Random().Next(100, 1000);
Console.WriteLine("Случайное число: " + rand);
int a = FindFirstDigit(rand);
int b = FindSecondDigit(rand); // Данное действие лишнее;
int c = FindThirdDigit(rand);
Console.WriteLine(a * 10 + c);

int FindFirstDigit(int r)
{
    int result = rand / 100;
    return result;
}

int FindSecondDigit(int r)
{
    int result = rand % 100 / 10;
    return result;
}

int FindThirdDigit(int r)
{
    int result = rand % 100 % 10;
    return result;
}