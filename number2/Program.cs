// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6
Console.WriteLine("Введите число");
string example = Console.ReadLine();
int a = Convert.ToInt32(example);
int result = -1;
if (a >= 100)
{
While (a > 99) 
{a = a/10;
Console.WriteLine($"число {a % 10}");
}
else
    Console.WriteLine($"число {a}");
}
else {
     int result = a % 10;