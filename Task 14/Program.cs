Console.WriteLine("Enter three numbers: ");
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

int max = int.MinValue;

if (first > max) {
    max = first;
}

if (second > max)
{
    max = second;
}

if (third > max)
{
    max = third;
}

// чи є коротший спосіб знайти макс?

Console.WriteLine("Result: " + max);
Console.ReadLine();

