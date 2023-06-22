// Prints out numbers from -a to a
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int start_num = -number; start_num <= number; start_num++)
{
    Console.Write(start_num + " ");
}
