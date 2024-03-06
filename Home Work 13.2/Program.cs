
/*. Написать программу, которая будет генерировать случайные числа от
1 до 10 и выводить их на экран до тех пор, пока не будет сгенерировано
число 7.
*/

using System;

Random random = new Random();
int random1 = random.Next(1, 11);

while (true)
{
    if (random1 != 7) Console.WriteLine($"Сгенирировано число {random1}");
    if (random1 == 7) Console.WriteLine($"Сгенирировано {random1}");
    break;
}




/*Написать программу, которая будет запрашивать у пользователя
числа, пока он не введет число 0. После этого программа должна
вывести сумму всех введенных пользователем чисел.*/


int userNum = 0;
int i = 0;

while (true)
{
    Console.Write("Введите любое число: ");
    int user = int.Parse(Console.ReadLine());

    if (user != 0)
    {
        userNum += user;
        i++;
    }
    if (user == 0)
    {
        Console.WriteLine($"Ваш результат {userNum + user}");
        break;
    }

}