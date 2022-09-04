// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*

void Number (int a, int b)
{
    int result = a;
    int i = 1;

    for(i = 1; i < b; i++)  
        {
            result *= a;
        }

    if(i == b) Console.WriteLine($"Число {a} в степени {b} = {result}");
    if(b < 0 || b == 0) Console.WriteLine("Вы ввели ненатуральную степень");
}

Console.Write ("Введите число которое нужно возвести в натуральную степень: ");
int a = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите натуральную степень: ");
int b = Convert.ToInt32 (Console.ReadLine());

Number(a,b);

*/

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*

int Number(int a)
{
    int res = 0;

    for (res = 0; a != 0; a /= 10)
        {
            res = a % 10 + res;
        }

        return res;
}

Console.Write ("Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine());

int res = Number (a);

Console.WriteLine ($"Cумма цифр в числе = {res}");

*/

// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*

void Massiv(int[] mass)
{
    int length = mass.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write ($"Введите {i+1} число массива: ");
        mass[i] = Convert.ToInt32 (Console.ReadLine());
    }
}


void printMassiv(int[] mass2)
{
    Console.Write("Массив из введеных Вами чисел следующий: [");
    for(int i = 0; i < mass2.Length; i++)
    {
        Console.Write($"{mass2[i]}, ");
    }
    Console.WriteLine("\b\b]");
}

 int[] array = new int[8];

Massiv(array);
printMassiv(array);

*/