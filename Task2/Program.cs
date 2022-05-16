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

Console.Write("Введите номер позиции искомого элемента (нумерация начинается с 0): ");
int x = int.Parse(Console.ReadLine()!);
int column, row;
if (x > m * n - 1)
{
    Console.WriteLine("Введенная позиция выходит за границы массива");
    return;
}
if (x == 0)
{
    column = 0; row = 0;
}
else
{
    column = x % n;
    row = x / n;
}
Console.Write($"Искомый элемент массива: " + matrix[row, column]);