
Console.WriteLine("Введите 10 целых чисел");


int[] mas = new int[10];
for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"Введите {i + 1} число: ");
    mas[i] = int.Parse(Console.ReadLine());
}
Array.Sort( mas );
foreach (int i in mas)
{
    Console.Write(i + " ");
}
Console.WriteLine();

Console.Write("Введите число которое желаете найти: ");
int serch = int.Parse(Console.ReadLine());
int index = Array.IndexOf(mas.ToArray(),serch);

Console.Write(index);

for (int i = 0; i < mas.Length; i++)
{
    if (index != serch || index == serch)
    {
        Console.WriteLine("");
    }
    else Console.Write("Такое число ненайдено.");
}












