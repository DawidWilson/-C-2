// 1.
long number = 264895468854; // 0011 1101 1010 1101 0000 0000 0001 0101 0011 0110
Console.WriteLine(~number);

long number1 = 256;         // 0001 0000 0000
Console.WriteLine(~number1);

// 2.
Console.WriteLine(number1<<2);
Console.WriteLine(number1 >> 2);
long number2 = 32856;
Console.WriteLine(number2 >>2);
Console.WriteLine(number2 << 2);

// 3.
long number3 = 289; long number4 = 144; long number5 = 36274;
Console.WriteLine($"{number3 += 2487}\n{number4 -= 2487}\n{number5 *= 2487}");