// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// пример из 5 элементов:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split()

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}


int[] arr = new int[8];

Console.WriteLine("Введите в консоль 8 чисел");
arr = Console.ReadLine().Split(' ', ',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

PrintArray(arr);
