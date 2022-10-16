// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньше.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("ввести число №1  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("ввести число №2  ");
int b = Convert.ToInt32(Console.ReadLine());

if (b > a)
{
    Console.Write("большее число № 2");
}
else
    Console.Write("меньшее число № 1");
