﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// Я понимаю данную задачу следующим образом: Имеется диапазон чисел, и из заданого диапазона рандомно выпадает число,
// и программа определяет какая цифра в числе третья и выводит ее, если же 3 цифры нет, программа сообщает
// что в данном числе нет третей цифры

int number = new Random().Next(10, 1000);
Console.WriteLine($"number: {number}");
int a = number / 100;
int b = (number / 10) % 10;
int c = number % 10;
if (number<100)
{
    Console.WriteLine("В заданом числе нет третей цифры");
}
else
{
Console.WriteLine($"Третья цифра в заданом числе: {c}");
}
