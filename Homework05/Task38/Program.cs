
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] InitArray()
{
    Random rnd = new Random();
    int length = rnd.Next(4, 11);
    double[] result = new double[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = rnd.Next(1, 10);
    }
    return result;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//первым возвращаем максимальный элемент, вторым - минимальный
(double, double) FindMaxAndMin(double[] array) // Функция, которая ищет минмальный и максимальный эдемент массива(в целом можно было бы сразу сделать функцию нахождения разности между ними, но я захотел потренироваться с использованием кортежей)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if( max < array[i] ) max = array[i];
        if( min > array[i] ) min = array[i];
        
    }
    return (max, min);
}

double[] array = InitArray();
PrintArray(array);
(double maxNumber, double minNumber) = FindMaxAndMin(array);
Console.WriteLine($"Разница между максимальным элементом массива и минимальным равна {maxNumber - minNumber}");
