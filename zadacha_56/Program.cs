// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

Metka:
int m = ReadInt("Укажите количество строк: ");
int n = ReadInt("Укажите количество столбцов: ");
System.Console.WriteLine();
if (m > 0 && n > 0 && m != n)
{
    var myMatrix = GenerateMatrix(m, n);
    System.Console.WriteLine("Сгенерированая матрица:");
    System.Console.WriteLine();
    PrintMatrix(myMatrix);
    System.Console.WriteLine();
    System.Console.WriteLine("Номер строки с наименьшей суммой элементов: " + GetRowMinSum(myMatrix));
}
else if (m > 0 && n > 0 && m == n)
{
    System.Console.WriteLine("Задана квадратная, а не прямоугольная матрица! Повторите ввод!");
    System.Console.WriteLine();
    goto Metka;
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

int GetRowMinSum(int[,] matrix)
{
    int[] sumArr = GetSumArr(matrix);
    return Array.IndexOf(sumArr, sumArr.Min()) + 1;
}

int[] GetSumArr(int[,] matrix)
{
    int[] sumArr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumArr[i] += matrix[i, j];
        }
    }
    return sumArr;
}