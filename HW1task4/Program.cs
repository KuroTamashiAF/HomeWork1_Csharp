Console.WriteLine("Enter a three-digit number: ");
int num = int.Parse(Console.ReadLine());
if (num > 99 && num < 999)
{
    int last_number = num % 10;
    Console.WriteLine("The last digit of this three-digit number is  ");
    Console.WriteLine(last_number);
}
else
    Console.WriteLine("You entered a non-three-digit number");
