﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();

Console.Write("Напишите число:");
int a = Convert.ToInt32(Console.ReadLine());
int res = a;
int sum = 0;

    while (a>0) {
        int b = a%10;
        a=a/10;
        sum=sum+b;
    }
    Console.Write("Сумма цифр в числе " + res + " = " +sum);