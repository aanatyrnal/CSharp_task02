// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int d = num / 10 % 10;
Console.WriteLine(d);
