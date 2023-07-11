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
    Console.WriteLine("Ничего не вышло... введите число побольше, хотя бы 2 и повторите попытку");
}

else 
{
    while (counter<=number) 
    {
        if (counter % 2 == 0) 
        {
            Console.WriteLine((counter));
        }
        counter = counter + 1;
    }
} 