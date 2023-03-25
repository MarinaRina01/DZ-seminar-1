// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число 1");
string OneNum = Console.ReadLine();
int One = Convert.ToInt32(OneNum);
Console.WriteLine("Введите число 2");
string TwoNum = Console.ReadLine();
int Two = Convert.ToInt32(TwoNum);
if (One > Two) {
    Console.WriteLine($"Большее число равно {One}, а меньшее {Two}");
} 
else {
    Console.WriteLine($"Большее число равно {Two}, а меньшее {One}");
}
