bool IsPalindrome(int number) // for any digit-length number
{
    
    int temp = number;
    int reversed = 0;
// if (number >= 10000 && number < 100000)  // add this condition for getting the solution for 5-digit numbers
    
    while (number > 0)
    {
        reversed = reversed * 10 + number % 10;
        number /= 10;
    }
    if (temp == reversed) return true;
    else return false;
}

Console.WriteLine(IsPalindrome(-13331));