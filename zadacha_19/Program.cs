// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Введите пятизначное число: ");
string? str = Console.ReadLine();
int a = Convert.ToInt32(str);

if (a >= 10000 && a <= 99999)
{
    if (str![0] == str[4] && str[1] == str[3])
    {
        System.Console.WriteLine("да");
    }
    else
    {
        System.Console.WriteLine("нет");
    }
}
else
{
    System.Console.WriteLine("Введено не пятизначное число!");
}

