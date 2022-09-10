// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*

int [] Massiv (int number, int minValue, int maxValue)
{
    int [] element = new int [number];
    for (int i = 0; i < number; i++)
        {
            element [i] = new Random().Next(minValue, maxValue);
        }

    return element;
}

void PrintMassiv (int [] number)
    {
        int b = 0;
        Console.Write ("Случайные положительные трехзначные числа: ");
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] % 2 == 0) b++;
            Console.Write (number[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine($"Kоличество чётных чисел в указанном массиве: {b}");
    }

int size = 10;
int min =  100;
int max = 1000;

int[] newArray = Massiv(size, min, max);
PrintMassiv(newArray);

*/

// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*

int [] Massiv (int size)
{
    int [] array = new int [size];

    for (int i = 0; i < size; i++)
        {
          array [i] = new Random().Next(-100, 100); // числа из 11 цифр выдавал, поэтому диапазон поставил.
        }

        return array;
}


void PrintMassiv (int [] number)
{
    Console.Write("Одномерный массив, заполненный случайными числами: ");
    int length = number.Length;
    for (int i = 0; i < length; i++) Console.Write($"{number [i]} ");

    Console.WriteLine();
}


int Sum (int [] massiv)
{
    int sum = 0;

    for ( int i = 0; i < massiv.Length; i++)
    {
        if(i % 2 != 0) sum += massiv[i];
    }
    return sum;
}

int size = 10;

int [] array = Massiv (size); 
PrintMassiv(array);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {Sum(array)}");

*/

// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*

double [] Massiv (int number)
{
    double [] array = new double [number];

    for (int i = 0; i < number; i++)
    {
      
       array[i] =  Math.Round(new Random().NextDouble(),3) + new Random().Next(1, 9);
    }
    return array;
}

void PrintMassiv (double [] number)
{
    Console.Write("Массив вещественных чисел: ");
    for(int i = 0; i < number.Length; i++) Console.Write($"{number[i]} ");
}

void MaxMin (double [] number)
{
    double max = number[0];
    double min = number[0];
    double sum = number[0];

    for(int i = 0; i < number.Length; i++)
    {
       if(number[i] > max) max = number[i];
    }

    for(int i = 0; i < number.Length; i++)
    {
       if(number[i] < min) min = number[i];
    }

    Console.WriteLine();
    Console.WriteLine($"Разницу между максимальным и минимальным элементов массива равна: {Math.Round(sum = max - min,3)}");
     
}

int number = 10;
double [] array = Massiv (number);
PrintMassiv(array);
MaxMin(array);

*/


