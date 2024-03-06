Random random = new Random();
int aiNumber = random.Next(1,6);
int user;
int i = 3;
do
{
    i--;
    Console.Write("Введите число от 1 до 5: ");
    user = int.Parse(Console.ReadLine());
    if (i < 3)
    {
        if (user == aiNumber) break;
        Console.WriteLine($"Попыток осталось {i}");
        if (i <= 0 )
        {
            Console.WriteLine();
            break;
        }
    }
}
while (user != aiNumber);
{
    if (user == aiNumber) Console.WriteLine($"Победа!");
    else Console.WriteLine($"Поражение :(\nЗагаданое число {aiNumber}");
}
