// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int GetConsole(string msg)
{
    Console.WriteLine(msg);
    int userNumber;
    while (true)
    {
        if(int.TryParse(Console.ReadLine(), out int number))
        {
            userNumber = number;
            break;
        }
        else Console.WriteLine("Вы ввели не число");
    }
    return userNumber;
}

void PrintNumbers (int number)
{
    if (number == 0) return;
    Console.Write(number + " ");
    PrintNumbers (number - 1);
}

int userNumber = GetConsole("Введите число");
PrintNumbers(userNumber);