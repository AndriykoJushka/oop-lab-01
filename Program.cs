Console.WriteLine("Input the number: ");
int num = int.Parse(Console.ReadLine());
String num_to_string = num.ToString();
char last_digit = num_to_string.Last();
Console.WriteLine("Last digit of your number: " + last_digit);
