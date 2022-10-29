// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out  int number))
        {
            result = number;
            break;
        }
        else
            Console.WriteLine("Вы ввели не число");
    }   
    return result;
}

int Exponentiation(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;   
    }
    return result;
}
int a = GetNumber("Введите число А");
int b = GetNumber("Введите число B");
int exponentiation = Exponentiation(a, b);
Console.WriteLine($"Число {a} в степени {b} равно {exponentiation}");

