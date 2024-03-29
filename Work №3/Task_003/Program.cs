﻿/*
Task №3:
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


// ---Вариант №1---
// Через функцию "while" и костыль в виде оформления чтобы скрыть "return".

double Cube(double num)
{
    double numb = num;
    double result = 0; 
    double count = 1;
    
    while(count <= numb)
    {
        double T = Math.Pow(count, 3);
        Console.WriteLine($"  {count}. Degree cube - {T} ");
        result = count;
        count++;                                   
    }
Console.Write("Cube degree number: ");
return result;   
}

Console.Write("Input number: ");
double num = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Cube(num));


// ---Вариант №2---
// Через функцию "for" через которую можно в одну строчку)


Console.Write("Input number: ");
double num = Convert.ToDouble(Console.ReadLine());

int iter = 0;

for(int count = 1; count <= num; count++)
{
    Console.WriteLine($"{iter + 1 * count}. Degree cube - {count * count * count}");
}


// ---Вариант №3---
//Аналогично функции с cеминара через "void".

void Cube(int num)
{

int numb = num;    
int count = 1;

    while (count <= numb)
    {
    int N = (count * count * count);
    Console.WriteLine(N);
    count++;
    }
  
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);


*/
// ---Вариант №4---
//Аналогично функции с cеминара через "void" и оператором "Math".

void Cube(double num)
{

double numb = num;    
double count = 1;

    while (count <= numb)
    {
    double N = Math.Pow(count, 3);
    Console.WriteLine($" {count}. Degree cube = {N} ");
    count++;
    }
  
}

Console.Write("Input number: ");
double num = Convert.ToDouble(Console.ReadLine());
Cube(num);