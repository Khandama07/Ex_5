Console.WriteLine("Введите значение ");
string num = Convert.ToInt32(Console.ReadLine()).ToString();

void CheckNumber(string num)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"Ваше число: {num} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {num} - НЕ палиндром.");
}

if (num.Length == 5)
{
    CheckNumber(num);
}
else Console.WriteLine($"Введи правильное число");


