﻿/*

Task №3:
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

//              --------------- !!!Несколько вариаций решения!!! -----------------

// Первый вариант:

Console.Write("Enter Number: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb %2 == 0)  

// Кслассический оператор в С№, где мы находим остаток от деления на 2 спомощью (%) и сравниваем (==) равен ли остаток нулю.

{               
    Console.Write("Even number");
}

else
{
    Console.Write("Odd number");
}


// Второй вариант:


Console.Write("Enter the Number: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb % 0x02 == 0) 

// Ещё одна формула, найдена на просторах форума поянение к ней отсуствует, но она работает).

{
    Console.Write("Even number");
}
else 
{
    Console.Write("Odd number");
}

// Третий вариант:

*/


Console.Write("Enter the Number: ");
int numb = Convert.ToInt32(Console.ReadLine());

if ((numb & 1) == 0) 

// Формула с использованием побитного N (у нечётного числа младший бит равен 1),
// что примечательно требует обязательных скобок для выполнения оператора в отличии того же х %2 == 0,
// который не требует обязательного написания как (х %2) == 0 

{
    Console.Write("Even number");
}
else 
{
    Console.Write("Odd number");
}