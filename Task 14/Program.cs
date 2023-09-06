Console.WriteLine("Enter three numbers: ");
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

int max = first;

if (second > max)
{
    max = second;
}

if (third > max)
{
    max = third;
}


Console.WriteLine("Result: " + max);

