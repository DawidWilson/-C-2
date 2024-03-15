int[,] mas = new int[4, 3];
Console.Write("Введите числа от 1 до 10: ");
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.Write("Введите число 200:");
int c = int.Parse(Console.ReadLine());
mas[2, 2] = c;
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write(mas[i, j] + " "); ;
    }
    Console.WriteLine();
}