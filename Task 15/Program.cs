Console.WriteLine("Enter three numbers: ");
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

String result;

if (first * second * third >= 0) {
    result = "Positive";
} else { result = "Negative"; }

Console.WriteLine("Result: " + result);
