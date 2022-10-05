// Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.WriteLine ("Введите число для координаты x точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число для координаты y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число для координаты z точки А: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число для координаты x точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число для координаты y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число для координаты z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt (Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2));
Console.WriteLine ($"{result:f2}");