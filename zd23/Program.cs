// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 23. Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

Console.Write("Введите  число:");
int num = Convert.ToInt32(Console.ReadLine());

if(num<10000 || num>99999 )

{
    Console.WriteLine("Число не пятизначное");
}
else
{
string str = Convert.ToString(num);
    if (str[0]==str[4]&& str[1]==str[3])
    {
        Console.WriteLine("Число "+str+" палиндром");
    }
    else
    {
         Console.WriteLine("Число "+str+" не палиндром");
    }

}