//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N


Console.WriteLine("Input number:");
int n =Convert.ToInt32(Console.ReadLine());
int i =1;
    while(i<=n)
    {
        int cub = i*i*i;
        i++;
        Console.WriteLine($"Таблица кубов {cub}");
    }
