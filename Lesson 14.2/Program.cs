
Random random = new Random();
int temperature = 0;


for (int i = 1; i > temperature; i++)
{
    temperature = random.Next(1, 101);

    if (temperature < 90)
    {
        Console.Write($"Текущая температура:{temperature}");
    }
    else
    {
        Console.Write($"Критическая температура:{temperature}");
        break;
    }
}









