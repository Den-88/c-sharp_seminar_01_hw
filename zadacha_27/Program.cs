// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine(GetResult());

string GetNumber()
{
    System.Console.Write("Введите число: ");
    return Console.ReadLine();
}

string GetResult()
{
    string num_text = GetNumber();
    int result = 0;
    for (int i = 0; i < num_text.Length; i++)
    {
        if (int.TryParse(num_text[i].ToString(), out int num))
        {
            result += num;
        }
        else
        {
            return "Введено не число!";
        }
    }
    return "Результат: " + result.ToString();
}