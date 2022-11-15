// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] InitArray()
{
    Random rnd = new Random();
    int length = rnd.Next(4, 11);
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = rnd.Next(1, 10);
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

int FindSumm(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i+=2)//Можно сделать через условие, которое проверяет, стоит ли элемент на нечетной позиции, но легче просто сделать шаг 2, а не 1
    {
        summ += array[i];
    }
    return summ;
}

int[] array = InitArray();
PrintArray(array);
int summ = FindSumm(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {summ}");
