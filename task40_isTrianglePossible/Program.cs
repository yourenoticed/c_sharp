﻿/* 40. Напишите программу, которая принимает на вход три числа
и проверяет, может ли существовать треугольник с сторонами такой длины. */

bool IsTrianglePossible(int sideA, int sideB, int sideC)
{
    if ((sideA + sideB > sideC) 
    && (sideB + sideC > sideA)
    && (sideC + sideA > sideB))
        return true;
    return false;
}

if (IsTrianglePossible(3, 4, 5))
    Console.WriteLine("The triangle is possible.");
else
    Console.WriteLine("The triangle is impossible.");