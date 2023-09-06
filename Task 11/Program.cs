Console.WriteLine("Input your number and digit: ");
int number = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
if (number < n) {
    Console.WriteLine("-");
}
string number_to_string = number.ToString();
char[] number_char_array = number_to_string.ToCharArray();
char result = number_char_array[n];
Console.WriteLine(result);
