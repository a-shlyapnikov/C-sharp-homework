// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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

int[,] InitSpiralMatrix(int size)
{
    int[,] spiralMatrix = new int[size, size];
    int element = 1;
    int i = 0;
    int j = 0;
    while (element <= size * size)
    {
        spiralMatrix[i, j] = element;
        if (i <= j + 1 && i + j < size - 1) j++;
        else if (i < j && i + j >= size - 1) i++;
        else if (i >= j && i + j > size - 1) j--;
        else i--;
        element++;
    }
    return spiralMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] < 10) Console.Write($"0{matrix[i,j]} ");
            else Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }

}

int size = GetConsole("Введите число строк и стобцов в матрице в матрице");
int[,] spiralMatrix = InitSpiralMatrix(size);
PrintMatrix(spiralMatrix);