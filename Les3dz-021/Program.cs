//Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.Write("Введите координаты точек Xa: ");
int Xa = int.Parse(Console.ReadLine()!); 
Console.Write("Введите координаты точек Ya: ");
int Ya = int.Parse(Console.ReadLine()!); 
Console.Write("Введите координаты точек Za: ");
int Za = int.Parse(Console.ReadLine()!); 

Console.Write("Введите координаты точек Xb: ");
int Xb = int.Parse(Console.ReadLine()!); 
Console.Write("Введите координаты точек Yb: ");
int Yb = int.Parse(Console.ReadLine()!); 
Console.Write("Введите координаты точек Zb: ");
int Zb = int.Parse(Console.ReadLine()!); 

int A = Xb-Xa;
int B = Yb-Ya;
int C = Za-Zb;

double length= Math.Sqrt(A + B + C );

Console.Write($"{length}");
