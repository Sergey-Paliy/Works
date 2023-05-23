// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
 Console.WriteLine("Input num:");
  int a=Convert.ToInt32(Console.ReadLine());
  int primer(int a)
  {
            int s = 0;
            while (a > 0)
            {
 
                s = s + a % 10;
                a = a /10 ;
 
            }
            return s;
  }
  int Primer =primer(a);
  Console.WriteLine($"Ответ {Primer}");
 




