// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Metka:
int m = ReadInt("Укажите количество строк: ");
int n = ReadInt("Укажите количество столбцов: ");
System.Console.WriteLine();
if (m > 0 && n > 0)
{
    var myMatrix = GenerateMatrix(m, n);
    System.Console.WriteLine("Сгенерированая матрица:");
    System.Console.WriteLine();
    PrintMatrix(myMatrix);
    System.Console.WriteLine();
    SortMatrixElements(myMatrix);
    System.Console.WriteLine("Преобразованная матрица:");
    System.Console.WriteLine();
    PrintMatrix(myMatrix);
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void SortMatrixElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int tempElement = matrix[i, j];
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] < tempElement)
                {
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = tempElement;
                    tempElement = matrix[i, j];
                }
            }
        }
    }
}