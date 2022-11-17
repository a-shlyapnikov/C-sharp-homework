// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetCoordinate(string msg)
{
    Console.Write(msg);
    double userNumber;
    while (true)
    {
        if(double.TryParse(Console.ReadLine(), out userNumber)) break;
        else Console.WriteLine("Вы ввели не число");
    }
    return userNumber;
}
string WriteFunction(double a, double b)
{
    string result = "y = " + Convert.ToString(a) + "x + " + Convert.ToString(b);
    return result;
}

string IntersectionCheck(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = x*k1 + b1;
    string result = Convert.ToString(x) + ";" + Convert.ToString(y);

    return result;
}



double numberB1 = GetCoordinate("Введите коэффициент b1 (угловой коэффициент): ");
double numberK1 = GetCoordinate("Введите коэффициент k1 (координата точки пересечения с осью ординат): ");
double numberB2 = GetCoordinate("Введите коэффициент b2 (угловой коэффициент): ");
double numberK2 = GetCoordinate("Введите коэффициент k2 (координата точки пересечения с осью ординат): ");

Console.WriteLine();

string function1 = WriteFunction(numberK1, numberB1);
string function2 = WriteFunction(numberK2, numberB2);
string coordinates = IntersectionCheck(numberK1, numberB1, numberK2, numberB2);
Console.Write($"Координаты точки пересечения функций {function1} и {function2}:\n({coordinates})");

// 5x+2 = 9x +4
// -9x + 5x = 2
// -4x = 2
// x = -0,5
// -0,5* 5 + 2 = - 0,5 
