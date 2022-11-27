// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetConsole(string msg)
{
    Console.WriteLine(msg);
    int userNumber;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            userNumber = number;
            break;
        }
        else Console.WriteLine("Вы ввели не число");
    }
    return userNumber;
}

void GetSumm(int userNumberM, int userNumberN, int summ)
{
    if (userNumberM > userNumberN)
    {
        Console.WriteLine($"Сумма чисел от M до N равна {summ}");
        return;
    }
    summ += (userNumberM++);
    GetSumm(userNumberM, userNumberN, summ);    
}

int m = GetConsole("Введите число M");
int n = GetConsole("Введите число N");
GetSumm(m, n, 0);
