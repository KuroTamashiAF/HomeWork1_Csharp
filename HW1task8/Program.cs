Console.Write("Enter the number to be checked  ");   // Число которое необходимо проверить на кратноть(проверяемое) 
int Checked_number = int.Parse(Console.ReadLine());
Console.Write("Enter a verification number  ");      // Число на которое будет происходить проверка на кратность(проверочное)
int verification_number = int.Parse(Console.ReadLine());
if (Checked_number % verification_number == 0)
{
    Console.WriteLine(Checked_number + "  Multiple  " + verification_number);
}
else
{
    Console.WriteLine(Checked_number + "  Is not multiple  " + verification_number);
    int Remainder = Checked_number % verification_number;
    Console.WriteLine("The remainder is   " + Remainder);
}