void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

Console.Write("Введите число строк в массиве: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов в массиве: ");
int n = int.Parse(Console.ReadLine()!);

double[,] matrix = new double[m, n];

FillArray(matrix);
PrintArray(matrix);

