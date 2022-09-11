// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*

int [] Massiv (int number)
{
    int [] array = new int [number];
    Console.WriteLine("Введите числа по одном через Enter: ");

    for(int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());

    return array;
}

void PrintMassiv (int [] number)
{
    int sum = 0;
    for(int i = 0; i < number.Length; i++)
    if(number[i] > 0)  sum++;
    Console.Write ($"Чисел больше 0 ввёл пользователь: {sum}");
    Console.WriteLine();
}

PrintMassiv (Massiv(5));

*/

// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*

void Formula(double x, double y, double b1, double k1, double b2, double k2)
{
    y = k1 * x + b1; y = k2 * x + b2;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения двух прямых, заданных уравнениями: y = k1 * x + b1, y = k2 * x + b2 равна ({x}; {y})");
}

Console.Write("Введите значение для b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение для k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите значение для b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение для k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = 0;
double y = 0;

Formula(x, y, b1, k1, b2, k2);

*/