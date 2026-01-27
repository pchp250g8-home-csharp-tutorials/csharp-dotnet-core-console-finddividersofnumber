// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input an integer positive number");
UInt64.TryParse(Console.ReadLine(),out ulong ulNumber);
Console.WriteLine("The number {0} has the folowing dividers:");
for(ulong i = 1; i <= ulNumber; i++)
{
    if (ulNumber % i == 0)
        Console.Write("{0} ", i);
}
Console.WriteLine();
Console.Read();