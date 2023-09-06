Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());
int factorial(int num) {
    if (num == 0) return 1;
    else return num * factorial(num - 1);
}

Console.WriteLine(factorial(number));
