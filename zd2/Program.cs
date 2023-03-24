// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1");
string OneNum = Console.ReadLine();
int One = Convert.ToInt32(OneNum);
Console.WriteLine("Введите число 2");
string TwoNum = Console.ReadLine();
int Two = Convert.ToInt32(TwoNum);
Console.WriteLine("Введите число 3");
string TriNum = Console.ReadLine();
int Tri = Convert.ToInt32(TriNum);
int max= 0;

if (One > Two) {
    max = One;
    if (One > Tri){
        max = One;
    }
    else {
        max = Tri;
    }
} 
else {
    max = Two;
    if (Two > Tri){
        max = Two;
    }
    else {
        max = Tri;
    }
}
Console.WriteLine($"Большее число равно: {max}");