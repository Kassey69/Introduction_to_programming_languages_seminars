// Задание 2.По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Введите первое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int value2 = Convert.ToInt32(Console.ReadLine());
int kvadrat_value2 = value2 * value2;

if (kvadrat_value2 == value1)
{
    Console.WriteLine("Квадрат второго числа соответствует первому");
}
else
{
Console.WriteLine("Первое число не является квадратом второго");

}

