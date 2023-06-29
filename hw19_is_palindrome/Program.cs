bool IsPalindrome(int number) // for any digit-length number
{
    
    int temp = number;
    int reversed = 0;
// if (number >= 10000 && number < 100000)  // add this condition for getting the solution for 5-digit numbers
    if (number > 0) // в случае, если число будет отрицательным, то будет читаться как 1234-, т.е. не может быть палиндромом по определению
    {
        while (number > 0)
        {
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }
        if (temp == reversed) return true;
        else return false;
    }
    else return false;
}

Console.WriteLine(IsPalindrome(13331));