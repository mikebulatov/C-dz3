// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 23. Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

int i,N;
Console.Write("Введите  число:");
N = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов чисел от 1 до "+Convert.ToString(N)+":::: ");
for(i=1;i<=N;i++)
    {
    Console.Write(Math.Pow(i,3));
    Console.Write(", ");
    }
    Console.WriteLine();
