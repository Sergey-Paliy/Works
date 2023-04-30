// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



double FindDistanse(double xa, double ya, double za, double xb, double yb,double zb)
{
    return Math.Round(Math.Sqrt(Math.Pow (xb-xa, 2)+ Math.Pow(yb-ya,2)+ Math.Pow(zb-za,2)),2);
}

Console.WriteLine("Input coordinate x to A:");
double xa =Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate y to A:");
double ya =Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate z to A:");
double za =Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate x to b:");
double xb =Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate y to a:");
double yb =Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate z to a:");
double zb =Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distanse between point A with coordinates {xa},{xb},{za} and point B with coordinates {xb}, {yb}, {zb} -> {FindDistanse(xa,ya,za,xb,yb,zb)} ");