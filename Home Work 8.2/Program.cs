//8.2.1
int momByAggs = 13;
int whenEatLeftAggs = 9;
Console.WriteLine($"Всего съели {momByAggs-whenEatLeftAggs} яиц");

//8.2.2
double magazineWidth = 25;
Console.WriteLine($"Ширина газеты {magazineWidth + 16}см");

// 8.2.3
double potato = 44;
double beet = 44/4;
double onion = beet/2;
Console.WriteLine($"Повар потратил {onion}кг лука");


//8.3.1

Console.WriteLine("Введите целое число:");
int number = int.Parse(Console.ReadLine());
int result = number % 8;
Console.WriteLine($"Ваш результат {result}");


//8.3.2

Console.WriteLine("Введите целое число №1:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число №2:");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целое число №3:");
int number3 = int.Parse(Console.ReadLine());

int resultSum = number1 + number2 + number3;
int resultWork = number1 * number2 * number3;

Console.WriteLine($"Сумма введеных чисел равна {resultSum}\nПроизведение введенных чисел {resultWork}");