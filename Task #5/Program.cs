// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
while (number > 1)
{
    if (number % 2 == 0) 
    {
    Console.WriteLine("Четное число " + number);
    }
    number = number - 1;
}
