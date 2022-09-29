// Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

/*

void ChislaOtDo(int m, int n)
{
    Console.Write(m + " ");
    if(m < n) ChislaOtDo(m+1, n);
}

ChislaOtDo(1, 9);
Console.WriteLine();

*/

// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*

int Summa(int m, int n)
{
    if(m <= n) return Summa(m+1, n) + m;
    else return 0;
}

Console.WriteLine(Summa(1, 8));

*/

// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*

int A (int m, int n)
{
    if(m == 0)  return n+1;
    if(m > 0 & n == 0)  return A(m-1, 1);
    if(m > 0 & n > 0) return A(m-1, A(m, n-1));
    return A(m,n);
}

Console.WriteLine(A(2, 3));

*/
