// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string GetNumber(string message) // Метод, который получает число из консоли
{
    string result;
    while(true)
    {
        Console.WriteLine(message);
        string n = Console.ReadLine()??"";
        int l = n.Length;
        if(int.TryParse(n, out int ignorMe) && l == 5) // проверка на то, что из консоли получили число и оно пятизначное
        {
            result = n;
            break;
        }
        else
            Console.WriteLine("Ввели не число или число является не пятизначным");
    }
    return result;
}

string number = GetNumber("Введите пятизначное число");
if (number[0] == number [4] && number[1] == number[3])
    Console.WriteLine($"Число {number} является палиндомом");
else
    Console.WriteLine($"Число {number} НЕ является палиндомом");

