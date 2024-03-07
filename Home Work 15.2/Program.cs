int[] mas = new int[10];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(0, 11);
    Console.Write(mas[i] + " ");
    i++;
}
Console.WriteLine();
foreach (int i in mas)
{
    if (i == 0) continue;
    if (i % 2 == 0 ) Console.Write(i + " ");
}