﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. Например 5 -> 2, 4: 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число > 1"); // В условии задачи не сказано, как программа должна вести себя с отрицательными числами, 0 и 1. Поскольку уточнений нет, ввожу условие, что N > 1 и проверку на него) 
string numberStr = Console.ReadLine(); 
int number = Convert.ToInt32(numberStr); 

if (number <= 1)
{
    Console.WriteLine("Вееденное число не корректно");
}

for (int i = 2; i <= number; i = i + 2) // Поскольку по условию задачи программа должна выдавать числа, начиная с 2, изначально задаю i = 2
{
       Console.Write($"{i}, ");
}
