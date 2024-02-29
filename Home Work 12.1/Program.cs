
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите операцию: ");
char operation = char.Parse(Console.ReadLine());

double total = 0;

switch (total)
{
    case 0: { total = number1 + number2; Console.WriteLine($"{number1}{operation}{number2}={total}"); } break;
    case 1: { total = number1 - number2; Console.WriteLine($"{number1}{operation}{number2}={total}"); } break;
    case 2: { total = number1 / number2; Console.WriteLine($"{number1}{operation}{number2}={total}"); } break;
    case 3: { total = number1 * number2; Console.WriteLine($"{number1}{operation}{number2}={total}"); } break;
}