// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*

double[,] Massiv2d(int m, int n)
{
    double [,] array2d = new double [m, n];

    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d [i, j] = Math.Round(new Random().NextDouble() + new Random().Next(1, 10),2);
        }
    }

    return array2d;
}

void PrintMassiv2d(double [,] massiv2d)
{
    for(int i = 0; i < massiv2d.GetLength(0); i++)
    {
        for(int j = 0; j < massiv2d.GetLength(1); j++)
        {
            Console.Write (massiv2d [i, j] + " ");
        }
         Console.WriteLine();
    }

}

int m = 5;
int n = 5;
double [,] array2d = Massiv2d(m, n);
PrintMassiv2d(array2d);

*/

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*

void PrintMassiv2d (int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,100);
            Console.Write($"{array[i,j]} ");
        }
            Console.WriteLine();
    }
}

 void PoiskIndex (int [,] array2d)
 {
    Console.WriteLine("Введите первое число индекса двумерного массива: ");
    int i = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите второе число индекса двумерного массива: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if(i >= array2d.GetLength(0) || i < 0 
    || j >= array2d.GetLength(1) || j < 0) Console.WriteLine ("Такого индекса в данном массиве нет.");

    else Console.WriteLine($"По введенному индексу находится следующее число массива: {array2d[i,j]}");
    
 }

int [,] array2d = new int [5, 5];

PrintMassiv2d(array2d);
PoiskIndex(array2d);

*/

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*

double [,] Massiv2d ()
{
    int stroka = 5;
    int stolbec = 5;
    double [,] array = new double [stroka, stolbec];
    for(int i = 0; i < stroka; i++)
        for(int j = 0; j < stolbec; j++)
           array[i,j] = new Random().Next(1,10);
    
    return array;

}

void MassivPrint (double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {    for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    
}

void SumPrint (double [,] array)
{
    double sum = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {   
        for(int i = 0; i < array.GetLongLength(0); i++)
        {
            sum += array[i,j]; 
        }   
        Console.WriteLine($"Cреднее арифметическое элементов {j+1} столбца равно {sum / array.GetLength(1)}");
        sum = 0;
    }
}
double [,] array = Massiv2d();
MassivPrint (array);
SumPrint(array);
Console.WriteLine();

*/