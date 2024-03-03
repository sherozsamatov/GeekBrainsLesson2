// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// Console.WriteLine("You entered " + number);

int min = 10;
int max = 99;


Console.WriteLine("Enter a number between 10 and 99: ");

int number = Convert.ToInt32(Console.ReadLine()); // 89

if (number < min) {
  System.Console.WriteLine("input cannot be less than 10, 10 is chosen");
  number = min;
}
else if (number > max) {
  System.Console.WriteLine("input cannot be greater than 99, 99 is chosen");
  number = max;
}

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit) {
  System.Console.WriteLine(firstDigit + " is greater!");
}

else if (firstDigit < secondDigit) {
  System.Console.WriteLine(secondDigit + " is greater!");
}

else {
  System.Console.WriteLine("First digit and second digit of your number are equal!");
}

