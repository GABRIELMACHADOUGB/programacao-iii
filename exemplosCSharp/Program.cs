using exemplosCSharp;

Console.WriteLine("Informe sua idade:");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine($"idade: {idade}");

Console.WriteLine("Informe seu nome:");
string nome = Console.ReadLine();
Console.WriteLine($"O nome é: {nome}");

Calculadora calc;
calc = new Calculadora();
int resultado = calc.Somar(5, 3);
Console.WriteLine(resultado);

resultado = Calculadora.Subtrair(10, 4);
Console.WriteLine(resultado);
