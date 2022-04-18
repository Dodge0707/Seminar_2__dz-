int number = RandomInt();
Console.WriteLine(number);
int index = 1;
while (index <=3)
{
Console.WriteLine("Угадайте, какое число загадала программа: ");
int myNumber = Convert.ToInt32(Console.ReadLine());
if (myNumber < number && index < 3)
{
    Console.WriteLine("Ваше число меньше!");
    Console.WriteLine("Попробуйте еще раз: ");
}
else if (myNumber > number)
{
    Console.WriteLine("Ваше число больше!");
    Console.WriteLine("Попробуйте еще раз: ");
}
else if (myNumber == number || index < 3)
{
    Console.WriteLine("Вы угадали!!!");
    break;
}
else if (myNumber !=number && index == 3)
{
    Console.WriteLine("Вы не угадали :( Попыток больше нет!!!");
}
index++;
}

int RandomInt()
 {
     return new Random().Next();
 }