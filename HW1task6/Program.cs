int num = new Random().Next(10, 100);
Console.WriteLine(num);
int first_digit = num / 10;
int second_digit = num % 10;
if (first_digit > second_digit)
{
    Console.Write("Largest digit: ");
    Console.Write(first_digit);
}
else
{
    Console.Write("Largest digit: ");
    Console.Write(second_digit);
}