// Напишите программу, которая будет принимать на вход 2 числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа вывводит остаток от деления
// Например:
// 34, 5 --> не кратно, остаток 4
// 16, 4 --> кратно

Console.WriteLine("Введите первое число: ");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b1 = int.Parse(Console.ReadLine());
Multiplicity(a1, b1);

void Multiplicity(int a, int b)
{
    if (a % b == 0)
    {
        Console.WriteLine(a + "," + b + " --> кратно");
    }
    else
    {
        Console.WriteLine("Числа " + a + "," + b + "--> не кратно, остаток " + a%b);
    }
}
