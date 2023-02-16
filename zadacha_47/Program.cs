// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = ReadInt("Укажите количество строк: ");
int n = ReadInt("Укажите количество столбцов: ");
System.Console.WriteLine();
PrintMatrix(GenerateMatrix(m, n));

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenerateMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // генерирую вещественные числа от -100 до 100 rand.NextDouble() * (maxValue - minValue) + minValue
            matrix[i, j] = Math.Round(rand.NextDouble() * (100 + 100) - 100, 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
