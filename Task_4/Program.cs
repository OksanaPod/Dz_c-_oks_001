Console.Write("Введите число A=");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B=");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C=");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
Console.Write("Ответ: максимальное число = ");
if (numberB > max)
{
    max=numberB;
}
if (numberC > max)
{
    max=numberC;
}
Console.WriteLine(max);