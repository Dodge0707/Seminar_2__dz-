Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int b = number.Length;
//Console.WriteLine(b);

if (b < 3)
{
    Console.WriteLine("Вы ввели слишком маленькое число");
}
else 
{
    Console.WriteLine(number[2]);
}