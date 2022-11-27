// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int GetConsole(string msg)
{
    Console.WriteLine(msg);
    int userNumber;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            userNumber = number;
            break;
        }
        else Console.WriteLine("Вы ввели не число");
    }
    return userNumber;
}

int Akkerman(int m, int n)
{
    if( m == 0) return n+= 1;
    else if(m > 0 && n == 0) return Akkerman(m-1, 1);
    else return Akkerman(m - 1, Akkerman(m, n-1));
}

int m = GetConsole("Введите число m");
int n = GetConsole("Введите число n");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

