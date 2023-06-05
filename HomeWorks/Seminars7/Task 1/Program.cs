// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] Create2DRandomArray(int rows, int colomns, int MinValue, int MaxValue)
{
    double [,] array=new double [rows, colomns];
    
        for (int i=0; i<rows; i++)
        {
            for (int j=0; j<colomns; j++)
            {
                array[i,j]=Convert.ToDouble(new Random().Next(MinValue,MaxValue));
            }
        }
        return array;
}

void Prin2DArray (double [,]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Imput numbers of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput numbers of colomns");
int colomns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput min value of array element");
int MinValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput max value of array element");
int MaxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив: ");
Prin2DArray(Create2DRandomArray(rows,colomns,MinValue,MaxValue));


