// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число > 1 :");
int num = int.Parse(Console.ReadLine());
int i = 1;
if (i >= num)
{
    if (i % 2 == 0)
    {
    Console.WriteLine(num);
    }
int num = num - 1;
int i = i + 1;
}
else
{
   Console.WriteLine("Нет четных чисел");
}