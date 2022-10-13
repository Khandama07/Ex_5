Console.WriteLine("Введите значение координат точек ");

int SetCoordinate(string coordinateName, string pointName)
{
    Console.WriteLine($"{pointName}: {coordinateName} = ");
    return Convert.ToInt32(Console.ReadLine());
}

int ax = SetCoordinate("x", "A");
int ay = SetCoordinate("y", "A"); ;
int az = SetCoordinate("z", "A"); ;
int bx = SetCoordinate("x", "B"); ;
int by = SetCoordinate("x", "B"); ;
int bz = SetCoordinate("x", "B"); ;

double result = Math.Round(Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2)), 2);
Console.WriteLine($"result = {result}");





