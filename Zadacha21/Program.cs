// Задача21. Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты двух точек");
double num1X = double.Parse(Console.ReadLine());
double num1Y = double.Parse(Console.ReadLine());
double num1Z = double.Parse(Console.ReadLine());
double num2X = double.Parse(Console.ReadLine());
double num2Y = double.Parse(Console.ReadLine());
double num2Z = double.Parse(Console.ReadLine());

double distination = Math.Sqrt(Math.Pow((num1X-num2X),2)+Math.Pow((num1Y-num2Y),2)+Math.Pow((num1Z-num2Z),2));

Console.WriteLine($"Рассояние между точками: {distination}");