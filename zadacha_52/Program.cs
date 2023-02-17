// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Metka:
int m = ReadInt("Укажите количество строк: ");
int n = ReadInt("Укажите количество столбцов: ");
System.Console.WriteLine();
if (m > 0 && n > 0)
{
    var myMatrix = GenerateMatrix(m, n);
    PrintMatrix(myMatrix);
    System.Console.WriteLine();
    System.Console.WriteLine("Среднее арифметическое каждого столбца:");
    System.Console.WriteLine(GetAveCol(myMatrix));
}
else
{
    System.Console.WriteLine("Количество строк и/или столбцов не может быть менее одного! Повторите ввод!");
    System.Console.WriteLine();
    goto Metka;
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    System.Console.WriteLine("Сгенерирована матрица:");
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

string GetAveCol(int[,] matrix)
{
    double sum = 0;
    string ave = String.Empty;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        ave += Math.Round(sum / matrix.GetLength(0), 2) + "\t";
        sum = 0;
    }
    return ave;
}