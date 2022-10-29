// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int GetNumber(string message)// Забирает число из консоли и проверяет число ли это
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

int GetDigitNumber(int number) // Метод, который считает количество цифр
{
    int i = 0;
    while (number > 0)
    {
        number /=10;
        i++;
    }
    return i;
}
int SummDigits(int number, int i) //Метод, который находит сумму цифр
{
    int summ = 0;
    for (int j = 0; j < i; j++)
    {
        summ += number % 10;
        number /= 10;
    }
    return summ;
}
int number = GetNumber("Введите число");
int numberDigits = GetDigitNumber(number);
int digitSumm = SummDigits(number, numberDigits);
Console.WriteLine($"Сумма чисел чила {number} равна {digitSumm}");