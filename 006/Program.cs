Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Square(numberA, numberB);

void Square(int numberA, int numberB)
{
    int resultA = numberA * numberA;
    int resultB = numberB * numberB;
    if (numberA == resultB || numberB == resultA)
    {
        Console.WriteLine("Да!");
    }
    else 
    {
        Console.WriteLine("Нет");
    }

}