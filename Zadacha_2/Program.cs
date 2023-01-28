System.Console.WriteLine("Введите число N: ");
int N = (Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine("Введите число Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (N > Y)
{
    System.Console.WriteLine("максимальное число из двух: " + N);
    System.Console.WriteLine("минимальное число из двух: " + Y);
}
else
{
    System.Console.WriteLine("максимальное число из двух: " + Y);
    System.Console.WriteLine("минимальное число из двух: " + N);
}