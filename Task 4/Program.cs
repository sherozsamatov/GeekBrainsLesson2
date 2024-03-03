// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

Console.WriteLine("Enter a natural N number: ");

int number = Convert.ToInt32(Console.ReadLine()); // 4578

int firstDigit;
int secondDigit;
int thirdDigit;
int fourthDigit;

if (number < 10)
{
  System.Console.WriteLine(number);
}

else if (number < 100)
{
  firstDigit = number / 10;
  secondDigit = number % 10;
  System.Console.WriteLine(firstDigit + ", " + secondDigit);
}

else if (number < 1000) {
  firstDigit = number / 100; 
  secondDigit = (number - firstDigit*100) / 10; 
  thirdDigit = number - firstDigit*100 - secondDigit*10; 
  System.Console.WriteLine(firstDigit + ", " + secondDigit + ", " + thirdDigit);
  
}



else if (number < 10000) {
  firstDigit = number / 1000; 
  secondDigit = (number - firstDigit*1000) / 100; 
  thirdDigit = (number - firstDigit*1000 - secondDigit*100)/10; 
  fourthDigit = (number - firstDigit*1000 - secondDigit*100) % 10; 
  System.Console.WriteLine(firstDigit + ", " + secondDigit + ", " + thirdDigit + ", " + fourthDigit);
  
}

else
{
  System.Console.WriteLine("END PROGRAM");
}