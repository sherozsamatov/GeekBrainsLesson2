// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int number = 322;

if (number % 161 == 0) {
  Console.WriteLine("The number is divisible by 7 and 23 at the same time");
}

else {
  Console.WriteLine("The number is not divisible by 23 or 7");
}