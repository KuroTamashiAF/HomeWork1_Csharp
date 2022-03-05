Console.WriteLine("Enter a three-digit number: ");
int num = int.Parse(Console.ReadLine());
if (num > 99 && num < 999)
{
    int last_number = num / 10 % 10;
    Console.WriteLine("The pre-last digit of a given three-digit number is  ");
    Console.WriteLine(last_number);
}
else
    Console.WriteLine("You entered a non-three-digit number");
