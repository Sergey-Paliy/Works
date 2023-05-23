// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Input X:");
  int x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y:");
int y=Convert.ToInt32(Console.ReadLine());
int degree =1;
for (int i=0; i<y; i++)
{
degree=degree*x;
}
Console.WriteLine($" {x}, {y} ->{degree}");