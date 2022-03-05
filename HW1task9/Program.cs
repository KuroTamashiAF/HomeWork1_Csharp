Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine());
if ((num / 100) >= 1)
{
    if (num < 1000)
    {
        int last = num % 10;
        Console.WriteLine("Third digit of the entered number is  " + last);
    }
    if (num > 1000 && num < 10000)
    {
        int last = (num / 10) % 10;
        Console.WriteLine("Third digit of the entered number is  " + last);
    }
    if (num > 10000 && num < 100000)
    {
        int last = (num / 100) % 10;
        Console.WriteLine("Third digit of the entered number is  " + last);
    }
    if (num > 100000 && num < 1000000)
    {
        int last = (num / 1000) % 10;
        Console.WriteLine("Third digit of the entered number is  " + last);
    }
    if (num > 1000000 && num < 10000000)
    {
        int last = (num / 10000) % 10;
        Console.WriteLine("Third digit of the entered number is  " + last);
    }
    if (num > 10000000 && num < 100000000)
    {
        int last = (num / 100000) % 10;
        Console.WriteLine("Third digit of the entered number is  " + last);
    }
    if (num > 100000000)
    {
        int last = (num / 1000000) % 10;
        Console.WriteLine("Third digit of the entered number is  " + last);
    }
    if (num > 1000000000 && num < 10000000000)
    {
        int last = (num / 10000000) % 10;
        Console.WriteLine("Third digit of the entered number is  " + last);
    }
}
else
{
    Console.WriteLine("The third digit of the number does not exist.");
}