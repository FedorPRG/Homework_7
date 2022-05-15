void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.Write("Введите число строк в массиве: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов в массиве: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

Console.Write("Введите номер ряда искомого элемента: ");
int mSearch = int.Parse(Console.ReadLine()!);

Console.Write("Введите номер столбца искомого элемента: ");
int nSearch = int.Parse(Console.ReadLine()!);

if (mSearch >= m | nSearch >= n)
{
    Console.Write("Такого числа в массиве нет");
}
else
{
    Console.Write("Искомый элемент массива: " + matrix[mSearch, nSearch]);
}
