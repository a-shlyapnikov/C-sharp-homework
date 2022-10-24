// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
double GetDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return distance;
}
int GetCoordinate(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(),out int number))
        {
            result = number; 
            break;
        }
        else 
        {
            Console.WriteLine("Ввели не число. Повторите ввод \n");
        }
    }
    return result;
}

int x1 = GetCoordinate("Введите координату x1");
int y1 = GetCoordinate("Введите координату y1");
int z1 = GetCoordinate("Введите координату z1");
int x2 = GetCoordinate("Введите координату x2");
int y2 = GetCoordinate("Введите координату y2");
int z2 = GetCoordinate("Введите координату z2");
double distance = GetDistance(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"Расстояние между точками A({x1}, {y1}, {z1}) и B({x2}, {y2}, {z2}) равно {Math.Round(distance, 2)}");