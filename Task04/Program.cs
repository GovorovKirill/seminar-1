﻿// Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// Например
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число и я покажу Вам максимальное");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a<b) {
    max = b;
}

if (c>max) {
   max=c;
}

Console.WriteLine($"максимальное число {max}");
