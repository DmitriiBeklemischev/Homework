 // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
    Console.WriteLine("Введите трехзначное число");
    int num = int.Parse(Console.ReadLine());
    int n1 = num / 10;
    int n2 = n1 * 10;
   int n3 = num - n2;
    Console.WriteLine("Последняя цифра числа = " + n3);