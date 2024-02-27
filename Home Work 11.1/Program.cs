
Console.WriteLine("Введите 10 целых чисел");
double sum = 0;
int CountGreat10 = 0;
int CountLess10 = 0;
double avg = 0;
int min;
int max;

Console.Write("Введите 1 число: ");
int num = int.Parse(Console.ReadLine());
sum += num;
CountGreat10 = (num > 10) ? CountGreat10++:CountGreat10 ;
CountLess10 = (num < 10) ? CountLess10++ : CountLess10;
min = num;
max = num;

Console.Write("Введите 2 число: ");
num = int.Parse(Console.ReadLine());
sum += num;
CountGreat10 = (num > 10) ? CountGreat10++ : CountGreat10;
CountLess10 = (num < 10) ? CountLess10++ : CountLess10;
if (num<min) min = num; 
if (num>max) max = num;


Console.Write("Введите 3 число: ");
num = int.Parse(Console.ReadLine());
sum += num;
CountGreat10 = (num > 10) ? CountGreat10++ : CountGreat10;
CountLess10 = (num < 10) ? CountLess10++ : CountLess10;
if (num < min) min = num;
if (num > max) max = num;

Console.Write("Введите 4 число: ");
num = int.Parse(Console.ReadLine());
sum += num;
CountGreat10 = (num > 10) ? CountGreat10++ : CountGreat10;
CountLess10 = (num < 10) ? CountLess10++ : CountLess10;
if (num < min) min = num;
if (num > max) max = num;


Console.Write("Введите 5 число: ");
num = int.Parse(Console.ReadLine());
sum += num;
CountGreat10 = (num > 10) ? CountGreat10++ : CountGreat10;
CountLess10 = (num < 10) ? CountLess10++ : CountLess10;
if (num < min) min = num;
if (num > max) max = num;


Console.Write("Введите 6 число: ");
num = int.Parse(Console.ReadLine());
sum += num;
CountGreat10 = (num > 10) ? CountGreat10++ : CountGreat10;
CountLess10 = (num < 10) ? CountLess10++ : CountLess10;
if (num < min) min = num;
if (num > max) max = num;


Console.WriteLine($" min {min}");
Console.WriteLine($"max {max}");
Console.WriteLine($"sum {sum}");
Console.WriteLine($"Больше 10 {CountGreat10}");
Console.WriteLine($"Меньше 10 {CountLess10}");
