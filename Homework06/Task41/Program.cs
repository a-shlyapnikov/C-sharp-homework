// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int GetNumber(string msg)
{
    int result = 0;
    int number;

    Console.WriteLine(msg);
    while(true)
    {
        Console.Write("Введите число: ");
        var userNumber = Console.ReadLine()??"";
        if (userNumber == ".") break;        
        number = int.Parse(userNumber);
        if (number > 0) result++;
    }
    
    return result;
}

int n = GetNumber("Введите числа, для окончания ввода нажмите '.'");
Console.WriteLine($"Количество числе больше 0 равно {n}");