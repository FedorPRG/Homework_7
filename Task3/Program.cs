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

void PrintArray1(double[] matr)
{
    for (int i = 0; i < matr.Length - 1; i++)
    {
        Console.Write(Math.Round(matr[i], 2) + "; ");
    }
    Console.Write(Math.Round(matr[matr.Length - 1], 2) + ".");
}

Console.Write("Введите число строк в массиве: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов в массиве: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);

double[] average = new double[n];

Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца:");
for (int i = 0; i < matrix.GetLength(1); i++)
{
    double summ = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        summ = summ + matrix[j, i];
    }
    average[i] = summ / matrix.GetLength(0);
}
PrintArray1(average);