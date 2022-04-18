Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberA = number % 7;
int numberB = number % 23;

if (numberA == 0 && numberB == 0)
{
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("Неа!");
}
