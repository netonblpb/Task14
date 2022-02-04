// Task14: Найти третью цифру числа или сообщить, что её нет

Random rnd = new Random();
int number = rnd.Next(10, 200);
Console.WriteLine("Берём число " + number);

string numberCheck = Convert.ToString(number);

if (numberCheck.Length > 2) Console.WriteLine("Третья цифра: " + numberCheck[2]);
else Console.WriteLine("В числе " + number + " меньше трёх цифр");