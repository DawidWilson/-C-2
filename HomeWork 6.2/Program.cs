
// Примеры встроеного метода GetType()
using System;

String stringDataType = "3345";
Console.WriteLine(stringDataType.GetType());

int intDataType = 346;
Console.WriteLine(intDataType.GetType());

// Примеры встроеного метода toString()
int intDataType_1 = 346;
Console.WriteLine(intDataType_1.ToString());

Double doubleDataType = 9890;
Console.WriteLine(doubleDataType.ToString());

// Примеры встроенного метода Parse()
int x = int.Parse(Console.ReadLine());
Console.WriteLine(x.ToString());

string myString = "284";
Console.WriteLine(int.Parse(myString));