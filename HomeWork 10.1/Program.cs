// ДЗ 10.1
Console.WriteLine("Введите значения радиуса окружности: ");
double R = double.Parse(Console.ReadLine());
double S = Math.Pow (Math.PI * R, 2);
double L = 2 * Math.PI * R;
Console.WriteLine($"Длина окружности {L}\nПлощадь окружности {S}");
//ДЗ 10.2
Console.WriteLine("Введите значение катета и гипатенузы");
double catet = double.Parse(Console.ReadLine());
double gipaten = double.Parse(Console.ReadLine());
double catet2 = (Math.Pow(catet, 2) - Math.Pow(gipaten,2));