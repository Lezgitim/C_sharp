// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*

bool Number (int a)
{   
    int count = a % 10;
    int count2 = 0;
    int b = a;

    if (a != 0 & a % 10 == 0) return false;

    while (count < a)
    {
        b = b / 10;
        count2 = b % 10;
        count = count * 10 + count2;

    }

    
    if (count == a & a >= 0) return true;
    
    else return false;
}

Console.WriteLine("Программа по нахождению палиндрома из целых чисел");
Console.Write("Введите число: ");

int b = Convert.ToInt32 (Console.ReadLine());

bool result = Number(b);

if (result) Console.WriteLine($"Введенное Вами число {b} является палиндромом!");
else 

Console.WriteLine($"Введенное Вами число {b} НЕ является палиндромом!");

*/

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

double Koordinati (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double ax = x1 - x2;
    double ay = y1 - y2;
    double az = z1 - z2;
    double dlina = Math.Sqrt(ax*ax + ay*ay + az*az);
    return dlina;
}

Console.Write($"Введите х координату первой точки: ");
double x1 = Convert.ToDouble (Console.ReadLine());
Console.Write($"Введите y координату первой точки: ");
double y1 = Convert.ToDouble (Console.ReadLine());
Console.Write($"Введите z координату первой точки: ");
double z1 = Convert.ToDouble (Console.ReadLine());

Console.Write($"Введите х координату второй точки: ");
double x2 = Convert.ToDouble (Console.ReadLine());
Console.Write($"Введите y координату второй точки: ");
double y2= Convert.ToDouble (Console.ReadLine());
Console.Write($"Введите z координату второй точки: ");
double z2 = Convert.ToDouble (Console.ReadLine());

double dlina = Koordinati (x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Длина между двумя заданными двумя точками в 3D пространстве ({x1}, {y1}, {z1} и {x2}, {y2}, {z2}) равна {dlina}");

*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*

void Number (int a)
{
    int index = 1;
    while(index <= a)
    {
        Console.WriteLine($"Куб числа {index} равен {index*index*index}");
        index++;
    }
    
    index = 1;
    while(index >= a)
    {
        Console.WriteLine($"Куб числа {index} равен {index*index*index}");
        index--;
    }

}

Console.WriteLine("Программа по нахождению кубов чисел от 1 до введенного Вами числа");
Console.Write("Введите число: ");

int b = Convert.ToInt32 (Console.ReadLine());

Number(b);

*/