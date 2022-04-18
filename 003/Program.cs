Console.WriteLine("Введите число соответствующее дню недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("День выходной!");
}
else if (number >= 1 && number <=5 )
{
    Console.WriteLine("День не выходной!!");
}
else 
{
    Console.WriteLine("Нет такого дня!");
}