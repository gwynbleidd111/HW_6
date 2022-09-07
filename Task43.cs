// ЗАДАЧА 43_____________________________________________________________


void GetXY(double a, double b, double c, double d){
    double x = -(a - c) / (b - d);
    double y = b * x + a;
    Console.WriteLine($"({x};{y})");
}

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

GetXY(b1,k1,b2,k2);
