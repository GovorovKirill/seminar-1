// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
// Например:
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

//string str = Console.ReadLine();
Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b) 
{
    Console.WriteLine($"{a} больше");
    Console.WriteLine($"{b} меньше");
}

if (a<b) 
{
    Console.WriteLine($"{b} больше");
    Console.WriteLine($"{a} меньше");
}

else 
{
    Console.WriteLine("числа равны");
}
