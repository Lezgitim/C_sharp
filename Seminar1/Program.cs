// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/* 
Console.Write ("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine ($"Большим числом является: {a}");
    Console.WriteLine ($"Меньшим числом является: {b}");
}
else
{
    Console.WriteLine ($"Большим числом являетcя: {b}");
    Console.WriteLine ($"Меньшим числом является: {a}");
}

if (a == b)
{
    Console.WriteLine ($"Числа: {a} и {b} равны между собой, большее или меньшее число отсутствует.");
}
*/




// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/* 
Console.Write ("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b; 
}

if (c > max)
{
    max = c;
}

 Console.WriteLine ($"Максимальным числом из введенных чисел является: {max}");
*/


// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write ("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine($"Введенное число {a} является четным.");
}
else
{
    Console.WriteLine($"Введенное число {a} не является четным.");
}
*/


// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write ("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = Convert.ToInt32(1);

while (count <= a)
{
    
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }

    count++;
}

 Console.WriteLine (); // Для переноса строки для ввода команд на следующую строку.
 */