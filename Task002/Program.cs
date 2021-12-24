Console.Write("Введите число А => ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B => ");
int numberB = int.Parse(Console.ReadLine());

if (numberB == numberA * numberA)
{
    Console.Write("Число B является квадратом числа A");
}
else
{
    Console.Write("Число B не является квадратом числа A");
}