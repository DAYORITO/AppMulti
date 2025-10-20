using AppMulti;

Calcular calc = new Calcular();

Console.WriteLine("Ingrese el primer número:");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Ingrese el segundo número:");
int num2 = int.Parse(Console.ReadLine() ?? "0");
int resultado = calc.multiplicar(num1, num2);
Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
