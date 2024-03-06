
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
