// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Metka:
int m = ReadInt("Укажите количество строк первой матрицы: ");
int n = ReadInt("Укажите количество столбцов первой матрицы: ");
System.Console.WriteLine();
if (m > 0 && n > 0)
{
    var myMatrixOne = GenerateMatrix(m, n);
    var myMatrixTwo = GenerateMatrix(n, m);
    System.Console.WriteLine("Сгенерированы две матрицы:\nПервая матрица:\n");
    PrintMatrix(myMatrixOne);
    System.Console.WriteLine("\nВторая матрица:\n");
    PrintMatrix(myMatrixTwo);
    System.Console.WriteLine("\nРезультат перемножения матриц:\n");
    PrintMatrix(MultiplicationMatrix(myMatrixOne, myMatrixTwo));
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

int[,] MultiplicationMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrixNew = new int[matrixOne.GetLength(0), matrixOne.GetLength(0)];
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            matrixNew[i, j] = GetElementOfNewMatrix(matrixOne, matrixTwo, i, j);
        }
    }
    return matrixNew;
}

int GetElementOfNewMatrix(int[,] matrixOne, int[,] matrixTwo, int numI, int numJ)
{
    int element = 0;
    for (int i = 0; i < matrixOne.GetLength(1); i++)
    {
        element += matrixOne[numI, i] * matrixTwo[i, numJ];
    }
    return element;
}