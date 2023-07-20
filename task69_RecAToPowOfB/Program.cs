/* Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии. */

int AToPowB(int a, int b)
{
    if (b <= 1)
    {
        return a;
    }
    else
    {    
        return a * AToPowB(a, b - 1);
    }
}

Console.WriteLine(AToPowB(2, 9));