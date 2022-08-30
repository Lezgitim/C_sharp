// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void Number(int a)
{
    int resultat = a;
    int resultat2 = a;
    if(a > 99 & a < 1000) 
    {
        a = a / 10;
        resultat = a % 10;
        Console.WriteLine($"Второй цифрой введенного Вами трехзначного числа является: {resultat}");
        a = a * 10;
    }   

    if (a < -99 & a > -1000) 
    {
        a = a / 10;
        resultat = a % 10;
        resultat2 = resultat * -1;
        Console.WriteLine($"Второй цифрой введенного Вами трехзначного числа является: {resultat} или {resultat2}");
        a = a * 10;
    } 

    if (a % 1000 != a) 
    {
        Console.WriteLine ("Внимание! Вы ввели не трехзначное число!");
    }

    if (a / 100 == 0) 
    {
        Console.WriteLine ("Внимание! Вы ввели не трехзначное число!");
    }
    
}

Console.Write ("Введите трехзначное число: ");

int b = Convert.ToInt32(Console.ReadLine());

Number(b);
*/


// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
void Number(int a)

{
    int resultat = a;
    int count = 10;

    while (a % count != a)
    {
        count = count * 10; 
    }  

    if (count <= 100) Console.WriteLine("третьей цифры нет");
    
    
    while (count > 1000) 
    {
        a = a / 10;
        count = count / 10; 
    }
    
    if(count == 1000) Console.Write($"Третьей цифрой введенного Вами числа является: {a % 10}");
    if(count == 1000 & a > 0) Console.WriteLine();
    if(count == 1000 & a < 0) Console.WriteLine($" или {a % 10 * -1}");
}

Console.Write("Введите число: ");

int b = Convert.ToInt32 (Console.ReadLine());

Number(b);
*/


// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
void Number(int a)

{
    int resultat = a;

    

    if (a > 5 & a < 8) Console.WriteLine($"{a} день недели является выходным днем");
    if (a > 0 & a < 6) Console.WriteLine($"{a} день недели НЕ является выходным днем!");
    if (a < 1) Console.WriteLine($"Введенное Вами число {a} не является днем недели!");
    if (a > 7) Console.WriteLine($"Введенное Вами число {a} не является днем недели!");
}

Console.Write("Введите число дней недели: ");

int b = Convert.ToInt32 (Console.ReadLine());

Number(b);
*/