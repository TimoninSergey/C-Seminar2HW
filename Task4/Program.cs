// Задача №4. Найти расстояние между точками в пространстве 2D/3D.

double Distance2D(double x1, double y1, double x2, double y2)
{
    double Distance = (Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2)));
    return Distance;
}

double Distance3D(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double Distance = (Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2)));
    return Distance;
}

Console.WriteLine("Введите мерность пространства");
string A = Console.ReadLine();
int N = int.Parse(A);

if (N == 2)
{
    Console.WriteLine ("Введите x1");
    double x1 = double.Parse(Console.ReadLine());
    Console.WriteLine ("Введите x2");
    double x2 = double.Parse(Console.ReadLine());
    Console.WriteLine ("Введите y1");
    double y1 = double.Parse(Console.ReadLine());
    Console.WriteLine ("Введите y2");
    double y2 = double.Parse(Console.ReadLine());
    
    double Distance = Distance2D(x1, x2, y1, y2);
    Console.WriteLine("Дистанция равна");
    Console.WriteLine(Distance);
}

else if (N == 3)
{
    Console.WriteLine ("Введите x1");
    double x1 = double.Parse(Console.ReadLine());
    Console.WriteLine ("Введите x2");
    double x2 = double.Parse(Console.ReadLine());
    Console.WriteLine ("Введите y1");
    double y1 = double.Parse(Console.ReadLine());
    Console.WriteLine ("Введите y2");
    double y2 = double.Parse(Console.ReadLine());
    Console.WriteLine ("Введите z1");
    double z1 = double.Parse(Console.ReadLine());
    Console.WriteLine ("Введите z2");
    double z2 = double.Parse(Console.ReadLine());
    
    double Distance = Distance3D(x1, x2, y1, y2, z1, z2);
    Console.WriteLine("Дистанция равна");
    Console.WriteLine(Distance);
}

else
{
    Console.WriteLine ("Мерность должна быть равна 2 или 3");
}
