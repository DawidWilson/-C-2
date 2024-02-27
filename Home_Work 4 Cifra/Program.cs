// Домашнее задание №4.1
Console.WriteLine("В Петербурге 5 598 486 жителей, в Москве 13 015 126. " +
                  "На сколько\r\nтысяч в Москве меньше жителей?\r\nЗадачу выполнить кодом," +
                  " с инициализацией переменных и выводом\r\nответа на консоль\n");
int moscow = 13015126;
int spb = 5598486;
Console.WriteLine($"В Москве жителей меньше на {(spb - moscow)/1000}\n\n\n");





// Домашнее задание № 4.2
Console.WriteLine("Работник заработал за год 260 548.56895р." +
                  " Сколько зарабатывает он в\r\nмесяц?" +
                  " А с вычетом НДФЛ?\r\nЗадачу выполнить кодом," +
                  " с инициализацией переменных и выводом\r\nответа на консоль\n");
const decimal WORKER = 260548.56895m;
const decimal NDFL = 13;
decimal mouth = (WORKER / 12);
Console.Write($"В месяц без вычета НДФЛ {mouth:F2}\n");
decimal procent = System.Math.Round((decimal)(mouth * NDFL) / 100);
Console.WriteLine($"В месяц зарплата с вычетом НДФЛ составляет {mouth - procent:F2}");
Console.WriteLine($"В месяц  НДФЛ работника составляет {procent}");
