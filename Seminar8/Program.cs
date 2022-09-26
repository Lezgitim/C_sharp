// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

/*

int[,] Massiv2d()
{
    int[,] array = new int[5, 5];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }

    return array;
}

void PrintMassiv2d (int [,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void VstrokeOtBolKMen(int [,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int n = 0; n < array.GetLength(1); n++) 
            {
                if(array[i, j] > array [i, n]) 
            // так как массив выводится, как я понимаю, 
            // начиная с последнего элемента измененного масива, поэтому ">".
                {
                   temp = array[i, j];
                   array[i, j] = array [i, n];
                   array [i, n] = temp;
                }
                
            }    
                
        }
    }

    
}

int [,] array2d = Massiv2d();

PrintMassiv2d(array2d); 
VstrokeOtBolKMen(array2d);
PrintMassiv2d(array2d);  

*/

// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*

int[,] Massiv2d()
{
    int[,] array = new int[5, 3];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
    return array;
}

void PrintMassiv2d(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void NaimSumStrok(int[,] array)
{
    int sum = 0;
    int temp = 0;
    int n = 0;
    int m = 0;
    int i = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    temp = sum;
    sum = 0;
    i = 1;
    m = i;
    n = temp;

    for (; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < temp)
        {
            temp = sum;
            n = sum;
            m = i + 1;
        }
        sum = 0;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {m} (сумма строки: {n})");
    Console.WriteLine();

}

int[,] array = Massiv2d();
PrintMassiv2d(array);
NaimSumStrok(array);

*/

// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*

int[,] Matrix()
{
    int[,] array = new int[2, 2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
    return array;
} 

 void PrintMatrix(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MatrixNaMatrix(int[,] array, int[,] array2)
{
    int [,] array3 = new int[2,2];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                array3[i,j] += array[i,k]*array2[k,j];
            }
            Console.Write(array3[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



int[,] array = Matrix();
PrintMatrix(array);
int[,] array2 = Matrix();
PrintMatrix(array2);
Console.WriteLine();
MatrixNaMatrix(array, array2);

*/

// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*

int[,,] Massiv2d()
{
    int[,,] array = new int[2, 2, 2];
    int minvalue = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(2); m++)
            {
                array[i, j, m] = minvalue;
                minvalue++;
            }
        }
    }
    return array;
}

void PrintMassiv2d(int[,,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < array.GetLength(2); m++)
            {
                Console.Write($"{array[i, j, m]} {(j, m, i)} ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[,,] array = Massiv2d();
PrintMassiv2d(Massiv2d());

*/

// Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.

/*

int[,] Massiv2d()
{
    int[,] array = new int[4, 4];
    int value = 10;
    int i = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = value++;
        }
    int n = 3;
        for (i = 1; i < array.GetLength(0); i++)
        {
            array[i, n] = value++;
        }
        for (i = 3, n = 2; n >= 0; n--)
        {
            array[i, n] = value++;
        }
        for (i = 2, n = 0; i >= 1; i--)
        {
            array[i, n] = value++;
        }
        for (i = 1, n = 1; n <= 2; n++)
        {
            array[i, n] = value++;
        }
        for (i = 2, n = 2; n >= 1; n--)
        {
            array[i, n] = value++;
        }

    return array;
}

void PrintMassiv2d (int [,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] array2d = Massiv2d();
PrintMassiv2d(array2d);

*/