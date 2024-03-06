Console.Write("Введите длину пароля: ");
int longPas = int .Parse(Console.ReadLine());
Random random = new Random();
int password = 0;

for (int i = 0; i < longPas; i++)
{
    password = random.Next(65, 115);
    Console.Write($"{(char)password}");
}