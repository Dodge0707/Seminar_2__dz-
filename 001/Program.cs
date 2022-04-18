Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberA = number / 10;
//Console.WriteLine(numberA);
int result = numberA % 10;
Console.WriteLine(result);
