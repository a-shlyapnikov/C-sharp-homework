// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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

int[,] InitMatrix(int m)
{
    Random rnd = new Random();
    int[,] matrix = new int[m, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] seconMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), seconMatrix.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < seconMatrix.GetLength(0); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * seconMatrix[k, j];
            }
        }
    }
    return resultMatrix;
}

int m = GetConsole("Введите число столбцов и строк в матрицах");// так как в условиях не сказано конкретики о размерностях матриц и проверки их на возможность умножения, будем умножать квадратные матрицы
int[,] firstMatrix = InitMatrix(m);
int[,] secondMatrix = InitMatrix(m);
PrintMatrix(firstMatrix);
PrintMatrix(secondMatrix);
int[,] matrixMultiplication = MultiplicationMatrix(firstMatrix, secondMatrix);
PrintMatrix(matrixMultiplication);



