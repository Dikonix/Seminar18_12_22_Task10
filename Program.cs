Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 99) && (number < 1000))
{
    number = number % 100 / 10;
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}