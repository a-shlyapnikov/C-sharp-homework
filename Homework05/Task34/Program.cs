// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] InitArray()
{
    Random rnd = new Random();
    int l = rnd.Next(5, 11);
    int[] result = new int[l]; 
    for (int i = 0; i < l; i++)
    {
        result[i] = rnd.Next(100, 1000);
    }
    return result;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int FindEvenNumbers(int[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) j++;
    }
    return j;
}

int[] array = InitArray();
PrintArray(array);
int numberOfEvenNumbers = FindEvenNumbers(array);
Console.WriteLine($"Колличество четных чисел в массиве равно {numberOfEvenNumbers}");
