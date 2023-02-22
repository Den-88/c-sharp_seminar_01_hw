// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int m = 4;
int n = 4;
System.Console.WriteLine("Сгенерированая матрица:");
System.Console.WriteLine();
PrintMatrix(GenerateMatrix(m, n));

int[,] GenerateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    WriteElements(matrix, 0, 0, 1, 1);
    return matrix;
}

void WriteElements(int[,] matrix, int row, int col, int count, int direction)
// direction - направление: 1 - направо, 2 - вниз, 3 - налево, 4 - вверх
{
    if (count <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        if (direction == 1)
        {
            if (col < matrix.GetLength(1) && matrix[row, col] == 0)
            {
                matrix[row, col] = count;
                WriteElements(matrix, row, col + 1, count + 1, 1);
            }
            else
            {
                WriteElements(matrix, row + 1, col - 1, count, 2);
            }
        }
        else if (direction == 2)
        {
            if (row < matrix.GetLength(0) && matrix[row, col] == 0)
            {
                matrix[row, col] = count;
                WriteElements(matrix, row + 1, col, count + 1, 2);
            }
            else
            {
                WriteElements(matrix, row - 1, col - 1, count, 3);
            }
        }
        else if (direction == 3)
        {
            if (col >= 0 && matrix[row, col] == 0)
            {
                matrix[row, col] = count;
                WriteElements(matrix, row, col - 1, count + 1, 3);
            }
            else
            {
                WriteElements(matrix, row - 1, col + 1, count, 4);
            }
        }
        else
        {
            if (row >= 0 && matrix[row, col] == 0)
            {
                matrix[row, col] = count;
                WriteElements(matrix, row - 1, col, count + 1, 4);
            }
            else
            {
                WriteElements(matrix, row + 1, col + 1, count, 1);
            }
        }
    }
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