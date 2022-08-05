// Задача 2: Напишите программу, которая на вход принимает два числаи выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.WriteLine("максимальное - ");
    Console.WriteLine(a);
    Console.WriteLine("минимальное  - ");
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("максимальное -");
    Console.WriteLine(b);
    Console.WriteLine("минимальное -");
    Console.WriteLine(a);
}