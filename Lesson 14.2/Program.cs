
//Random random = new Random();
//int temperature = 0;


//for (int i = 1; i > temperature; i++)
//{
//    temperature = random.Next(1, 101);

//    if (temperature < 90)
//    {
//        Console.Write($"Текущая температура:{temperature}");
//    }
//    else
//    {
//        Console.Write($"Критическая температура:{temperature}");
//        break;
//    }
//}



using System;

class Program
{
    static void Main()
    {
        Console.Write("Укажите количество квадратов: "); // Просим пользователя указать кол-во квадратов
        int quantity = Convert.ToInt32(Console.ReadLine());// принимаем ввод от пользователя

        Console.Write("Укажите сторону квадрата: "); // Просим указать сторону квадратов
        int weigth = Convert.ToInt32(Console.ReadLine());// принимаем ввод от пользователя

        for (int i = 0; i < quantity; i++) // Запускаем цикл где проверяем I<quontity
        {
            for (int j = 0; j < weigth; j++) // Запускаем цикл где проверяем I<weigth
            {
                Console.Write("*"); // Выводим на экран * по вертикали 
                Console.Write(" "); // Выводим пробелы
            }
            Console.WriteLine(); // делаем переход на новую строку
            for (int k = 0; k < weigth - 2; k++) // запускаем цикл и задаем ширину квадратов
            {
                Console.Write("*"); // Выводим на экран горизонтальные *
                for (int l = 0; l < weigth + weigth - 2; l++) // запускаем цикл для ширины вертикальной линии правой
                {
                    Console.Write(" ");// Выводим пробелы
                }
                Console.Write("*"); // Выводим *
                Console.WriteLine(); // Переход на новую строку
            }
            for (int m = 0; m < weigth; m++) // Запускаем цикл для определения нижней линии 
            {
                Console.Write("*"); // выводим ее
                Console.Write(" "); // выводим пробелы
            }

            Console.WriteLine();// переход на новую строку
        }
    }
}









