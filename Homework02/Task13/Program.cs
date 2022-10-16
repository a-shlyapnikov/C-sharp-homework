// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int GetThird(int n, int l) //Метод, который находит третью цифру и возвращает ее
{
    int t = 1;
    for(int i = l; i > 3; i--)
        t = t * 10;
    int k = (n / t) % 10;
    return k;
    
}

Console.Write("Введите число: ");
int number = int.Parse((Console.ReadLine()??""));
int length = number.ToString().Length;
if(number < 100)
    Console.WriteLine($"В числе {number} нет третьей цифры");
else
{
    int thirdDigit = GetThird(number, length);
    Console.WriteLine($"Третья цифра числа {number}: {thirdDigit}");
    //Также можно сделать следующим образом :
    // string str = number.ToString();
    // Console.WriteLine($"Третья цифра числа {number} {str[2]} ");
}
    