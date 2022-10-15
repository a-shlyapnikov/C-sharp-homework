// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите два числа");
int numberOne = int.Parse(Console.ReadLine()??"");
int numberTwo = int.Parse(Console.ReadLine()??"");
if(numberOne > numberTwo)
{
    Console.WriteLine($"Наибольшее число {numberOne}, наименьшее число {numberTwo}");
}
else
{
    Console.WriteLine($"Наибольшее число {numberTwo}, наименьшее число {numberOne}");
}
