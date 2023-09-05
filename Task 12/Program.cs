Console.WriteLine("Enter your number: ");
int number = int.Parse(Console.ReadLine());
bool result;

if (number > 20 && number % 2 == 1)
{
    result = true;
}
else { result = false; } 

// чому не можна без else case прописати код? (вибиває помилку, себто result не має value)

Console.WriteLine(result);
Console.ReadLine();