// Escreva um programa que pergunte o raio de uma circunferência, e em seguida mostre o diâmetro, comprimento e área da circunferência.

Console.WriteLine($"");

Console.Write("Digite o raio da circuferencia: ");
float raio = float.Parse(Console.ReadLine()!);

Console.WriteLine($"");

double pi = Math.PI;

float diametro = raio * 2;
double comprimento = 2 * pi * raio;
double area = pi * Math.Pow(raio, 2);

Console.WriteLine($"O raio da circuferencia e {raio}, o diametro {Math.Round(diametro, 2)}, o comprimento {Math.Round(comprimento, 2)} e a area {Math.Round(area, 2)}.");

Console.WriteLine($"");
