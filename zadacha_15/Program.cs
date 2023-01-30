// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет

System.Console.Write("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 1 || a > 7)
{
    System.Console.WriteLine("Такого для недели не существует");
}
else
{
    if (a >= 6)
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}