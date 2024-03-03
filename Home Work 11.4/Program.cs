Console.WriteLine($"{"Добро пожаловать!",46}");
Console.WriteLine($"Кандидаты в президенты солнечного города:\n{"1.Незнайка",39}\n{"2.Лунтик",37}\n{"3.Карлсон",38}\n{"4.Дядя Фёдор",41}");

Console.Write("Введите свой возраст: ");
int user = int.Parse(Console.ReadLine());

if (user < 18) Console.WriteLine("Вы слишком молоды для участия в выборах ");
if (user == 18 || user >= 35) Console.WriteLine("Вы можете участвовать в выборах в качестве депутата");
if (user == 36 || user >= 65) Console.WriteLine("Ваш возраст слишком велик для участия в выборах");

Console.Write("За кого из кондидатов вы будте голосавать? ");
int president = int.Parse(Console.ReadLine());

if (president == 1) Console.WriteLine("Незнайка:\nА у тебя в животе арбуз вырастет!!!");
else if (president == 2) Console.WriteLine("Лунтик:\nЖизнь — это одно большое приключение!");
else if (president == 3) Console.WriteLine("Карлсон;\nЯ мужчина хоть куда! В полном расцвете сил");
else if (president == 4) Console.WriteLine("Дядя Фёдор:\nЯ ничей. Я сам по себе мальчик. Свой собственный. Я из города приехал.");



// **** 
//Random random = new Random();
//int mouth = random.Next(1, 13);

//Console.Write("Угодайте сколько дней в загаданом месяце: ");
//int userAnswer = int.Parse(Console.ReadLine());

//if (userAnswer == 31)
//{
//    if (mouth == 1) Console.WriteLine("Январь");
//    else if (mouth == 3) Console.WriteLine("Март");
//    else if (mouth == 5) Console.WriteLine("Май");
//    else if (mouth == 7) Console.WriteLine("Июль");
//    else if (mouth == 8) Console.WriteLine("Август");
//    else if (mouth == 10) Console.WriteLine("Октябрь");
//    else if (mouth == 12) Console.WriteLine("Декабрь");
//    else if (mouth == userAnswer) Console.WriteLine("Wins");
//}
//if (userAnswer == 30)
//{
//    if (mouth == 4) Console.WriteLine("Апрель");
//    else if (mouth == 6) Console.WriteLine("Июнь");
//    else if (mouth == 9) Console.WriteLine("Сентябрь");
//    else if (mouth == 11) Console.WriteLine("Ноябрь");
//    else if (mouth == userAnswer) Console.WriteLine("Wins");
//}
//if (userAnswer == 29)
//{
//    if (mouth == 2) Console.WriteLine("Февраль");
//    else if (mouth == userAnswer) Console.WriteLine("Wins");

//}


