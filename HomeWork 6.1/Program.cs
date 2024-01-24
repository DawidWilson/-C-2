// Исходный тип данных
string theOriginDataType = "28";
Console.WriteLine(theOriginDataType.GetType());

// Конвертируем в byte
byte byteDataType = Convert.ToByte(theOriginDataType);
Console.WriteLine(byteDataType.GetType());

//Конвертируем из byte в nint
nint nintDataType = Convert.ToInt32(byteDataType);
Console.WriteLine(nintDataType.GetType());

// Конвертируем из nint в int
int intDataType= Convert.ToInt32(nintDataType);
Console.WriteLine(intDataType.GetType());

// Конвертируем из int в long
long longDataType = Convert.ToInt64(intDataType);
Console.WriteLine(longDataType.GetType());

// Конвертируем из long в double
double doubleDataType = Convert.ToDouble(longDataType);
Console.WriteLine(doubleDataType.GetType());