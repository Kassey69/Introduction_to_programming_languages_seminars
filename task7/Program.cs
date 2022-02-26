/*Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0) 
{
    Console.WriteLine("число четное");
}
else 
{
    Console.WriteLine("число нечетное");
}
if (number % 2 == 0)
{
    Console.WriteLine("число делится на 2");
}
else
{
     Console.WriteLine("не делится на 2, без остатка");
}