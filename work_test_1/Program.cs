﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое //меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


//Console.WriteLine("Write a number : ");
//Console.Write("a = ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("b = ");
//int b = int.Parse(Console.ReadLine());
//int max;
//max = a;
//if ( b > max )
//    max = b;
//Console.Write("max = ");
//Console.WriteLine(max);


Console.WriteLine("Write a number : ");
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
Console.Write("max = ");
if (a > b)
    Console.WriteLine(a);
else
    Console.WriteLine(b);
