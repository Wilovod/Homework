﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите целое число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

Console.WriteLine($"M={M}; N={N} -> {SumMN(N,M)}");

int SumMN(int N, int M)
{
    if (N == M) return M;
    else return sum = SumMN(N - 1, M) + N;
}