// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите натуральное число ");
string OneNum = Console.ReadLine();
int One = Convert.ToInt32(OneNum);
if (One <= 0)
{
    Console.WriteLine("Число не является натуральным");
}
else
{
    for (int i = 1; i <= One; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i} ");
        }
    }
}
