// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// Например
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число, и я Вас удивлю");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 1;

if (number <= 1) 
{
    Console.WriteLine("Четных чисел нет");
}

else 
{
    counter = 1;
    while (counter<=number && counter % 2 == 0) 
    {
        Console.Write(counter + " ");
        counter = counter = 1;
    }
} 