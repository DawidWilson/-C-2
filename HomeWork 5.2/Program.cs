                                            // Задание 5.2 

// Объявляем переменные всех товаров
string coFee = "КОФЕ СТАНДАРТНЫЙ";
string rulLet = "РУЛЕТ-СПРИНГ ТВ ИЗ";

// Задаем цену всех товаров
decimal standartCofee = 69.00m;
decimal rulletSpring = 70.00m;

// Считаем НДС первого товара 18 %
decimal ndsCofee = (standartCofee / 118) * 18;
// Считаем НДС второго товара 10 %
decimal ndsSpring = (rulletSpring / 110) * 10;

// Считаем общую сумму всех товаров
decimal totalPrice = standartCofee + rulletSpring;

// Считаем НДС итога чека первого товара 18%

// Выводим данные на чек первого товара
Console.WriteLine($"\t\t\t**************************************************************\n\t\t\t№ Название\t\t\t\tЦена\tКол.\tСумма\n\n\t\t\t1. {coFee}\t\t\t{standartCofee}\t1,00\t{standartCofee}\n\t\t\t   НДС с расчитаной ставкой 18%\t\t\t\t{ndsCofee:F2}\n\t\t\t");

// Выводим данные на чек второго товара
Console.WriteLine($"\t\t\t2. {rulLet}\t\t\t{rulletSpring}\t1,00\t{rulletSpring}\n\t\t\t   КУ\t\t\t\t\t\t\t{ndsSpring:F2}\n\n\n\t\t\t**************************************************************\n\t\t\tИТОГО:\t\t\t\t\t\t\t{totalPrice}\n");
// Выводим строку вид опалаты (Электронные средства)
Console.WriteLine($"\t\t\tЭлектронные средства\t\t\t\t\t{totalPrice}");

// Считаем НДС итога чека первого товара 18%
decimal ndsTotalPrice18 = (totalPrice / 118) * 18;
Console.WriteLine($"\t\t\tНДС итога чека с\t\t\t\t\t{ndsTotalPrice18:F2}\n\t\t\tрасчитаной ставкой\n\t\t\t18%");

// Считаем НДС итога чека первого товара 10%
decimal ndsTotalPrice10 = (totalPrice / 110) * 10;
Console.WriteLine($"\t\t\tНДС итога чека с\t\t\t\t\t{ndsTotalPrice10:F2}\n\t\t\tрасчитаной ставкой\n\t\t\t10%\n\n");

// Выводим доп информацию на чек
Console.WriteLine("\t\t\t**************************************************************\n\t\t\tВИД НАЛОГООБЛОЖЕНИЯ: ОСН\n\t\t\tРЕГ.НОМЕР ККТ: 0000143873023483\n\t\t\tЗАВОД №:\n\t\t\tФН №:8710000100265168\n\t\t\tФД №: 6026\n\t\t\tФПД: 3322278314\a");