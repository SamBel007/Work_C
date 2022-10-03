//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8


Console.WriteLine("Write a number N : ");
int a = int.Parse(Console.ReadLine());
int Num = 2;
while ( Num <= a)
{
    Console.Write(Num);
    Console.Write(", ");
    Num += 2;
}
