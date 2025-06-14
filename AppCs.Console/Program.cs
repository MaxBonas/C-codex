using AppCs.Library;

var calculator = new Calculator();

Console.Write("Ingrese el primer entero: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Ingrese el segundo entero: ");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"{a} + {b} = {calculator.Add(a, b)}");
Console.WriteLine($"{a} - {b} = {calculator.Subtract(a, b)}");
Console.WriteLine($"{a} * {b} = {calculator.Multiply(a, b)}");
try
{
    Console.WriteLine($"{a} / {b} = {calculator.Divide(a, b)}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: División por cero");
}
