Console.Write("Enter a three-digit number:  ");
int num = int.Parse(Console.ReadLine());
int first_digit = num / 100;
int second_digit = (num / 10) % 10;
int third_digit = num % 10;
Console.WriteLine("First digit: " + first_digit + "   Third digit: " + third_digit);   /*поскольку по заданию сказано удалить 
2 цифру из трехзначного числа то мы ее просто не будем выводить и все */
