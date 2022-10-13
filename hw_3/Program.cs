Console.WriteLine("Введите число ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i}^{num} = {Math.Pow(i, 3)}");
}
