// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5 
// 782 -> 8
// 918 -> 1
Random createNumber = new Random(); 
int number = createNumber.Next(100,1000);
Console.WriteLine($"The first number is {number}");
int b = number / 10 % 10;

Console.WriteLine($"The number is {b}");