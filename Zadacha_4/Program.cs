System.Console.Write("Введите число " );
int numberA=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число " );
int numberB=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число " );
int numberC=Convert.ToInt32(Console.ReadLine());
if (numberA>numberB && numberA>numberC)
{
     System.Console.WriteLine("максимальное число: "+numberA);
}
else if (numberB>numberA && numberB>numberC)
{
      System.Console.WriteLine("максимальное число: "+numberB);

}
else if (numberC>numberB && numberC>numberA)
{
    System.Console.WriteLine("максимальное число: "+numberC);
}
