// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число ");
string OneNum = Console.ReadLine();
int One = Convert.ToInt32(OneNum);
if (One % 2 == 0) {
    Console.WriteLine($"Число {One} является четным");
}
else {
    Console.WriteLine($"Число {One} является нечетным");
}