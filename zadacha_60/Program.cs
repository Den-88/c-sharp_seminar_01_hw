// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Metka:
int m = ReadInt("Укажите количество элементов в первом измерении: ");
int n = ReadInt("Укажите количество элементов во втором измерении: ");
int u = ReadInt("Укажите количество элементов в третьем измерении: ");

System.Console.WriteLine();
if (m > 0 && n > 0 && u > 0 && m * n * u < 91)
{
    var myArray = GenerateArray(m, n, u);
    System.Console.WriteLine($"Сгенерирован массив размером {m} x {n} x {u}:\n");
    PrintArray(myArray);
}
else if (m < 1 || n < 1 || u < 1)
{
    System.Console.WriteLine("Количество в каком-либо из измерений не может быть менее одного! Повторите ввод!");
    System.Console.WriteLine();
    goto Metka;
}
else
{
    System.Console.WriteLine("Массив такого размера не может содержать НЕПОВТОРЯЮЩИЕСЯ ДВУЗНАЧНЫЕ элементы! Повторите ввод!");
    System.Console.WriteLine();
    goto Metka;
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GenerateArray(int numM, int numN, int numU)
{
    int[,,] array = new int[numM, numN, numU];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = Randomazer(array);
            }
        }
    }
    return array;
}

int Randomazer(int[,,] arr)
{
    var rand = new Random();
    int tempRand = rand.Next(10, 100);
    if (CheckElement(tempRand, arr))
    {
        return tempRand;
    }
    else
    {
        return Randomazer(arr);
    }
}

bool CheckElement(int myRand, int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == myRand)
                {
                    return false;
                }
            }
        }
    }
    return true;
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            }
            System.Console.WriteLine();
        }
    }
}
