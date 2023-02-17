// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив: (ПРИМЕР С ОШИБКОЙ!!!)
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Metka:
int m = ReadInt("Укажите количество строк: ");
int n = ReadInt("Укажите количество столбцов: ");
System.Console.WriteLine();
if (m > 0 && n > 0)
{
    var myMatrix = GenerateMatrix(m, n);
    PrintMatrix(myMatrix);
    System.Console.WriteLine();
    int searchM = ReadInt("Укажите номер строки искомого элемента: ");
    int searchN = ReadInt("Укажите номер столбца искомого элемента: ");
    System.Console.WriteLine();
    System.Console.WriteLine(GetElement(myMatrix, searchM, searchN));
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

string GetElement(int[,] matrix, int row, int col)
{
    if (row <= matrix.GetLength(0) && col <= matrix.GetLength(1) && row > 0 && col > 0)
    {
        return $"Значение искомого элемента: {matrix[row - 1, col - 1]}";
    }
    return "В матрице не существует элемента с указанными координатами!";
}
