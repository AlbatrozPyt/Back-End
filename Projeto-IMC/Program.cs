Console.WriteLine(@$"

---------------------
|   Programa para   |
|   calcular IMC    |
---------------------
");


Console.WriteLine($"Digite o nome do paciente:");
string nome = Console.ReadLine();

Console.WriteLine($"Digite o peso de {nome}:");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a Altura de {nome}:");
float altura = float.Parse(Console.ReadLine());

float imc = (peso / ((float)Math.Pow(altura, 2)));

Console.WriteLine($"O paciente {nome} tem o IMC de {imc}");



