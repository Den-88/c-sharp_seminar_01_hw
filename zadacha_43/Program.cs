// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Координаты точки пересечения: (" + GetResult(ReadNum("b1"), ReadNum("k1"), ReadNum("b2"), ReadNum("k2")) + ")");

double ReadNum(string str)
{
    System.Console.Write("Введите значение " + str + ": ");
    return Convert.ToDouble(Console.ReadLine());
}

string GetResult(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return $"{x}; {y}";
}
