// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите три числа");
int numberOne = int.Parse(Console.ReadLine()??"");
int numberTwo = int.Parse(Console.ReadLine()??"");
int numberThree = int.Parse(Console.ReadLine()??"");
if(numberOne > numberTwo)
{
    if(numberOne > numberThree)
    {
        Console.WriteLine($"Максимальное число {numberOne}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {numberThree}");
    }
}
else
{
    if(numberTwo > numberThree)
    {
        Console.WriteLine($"Максимальное число {numberTwo}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {numberThree}");
    }
}
