// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100)
{
    while (a >= 1000)
    {
        a = a / 10;
    }
    System.Console.WriteLine($"Третья цифра заданного числа: {a % 10}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет!");
}
