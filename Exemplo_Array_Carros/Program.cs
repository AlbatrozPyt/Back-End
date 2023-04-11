string[]carros = new string[3];

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(@$"
____________________

   Lista de Carros
____________________
");
Console.ResetColor();

for (int i = 0; i < 3; i++) {
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.Write($"Digite o nome do {i+1}º Carro: ");
    carros[i] = Console.ReadLine()!;
    Console.ResetColor();
}

Console.WriteLine($"");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"________________________");
Console.WriteLine($"");

int cont = 1;
foreach  (var car in carros) {
    Console.WriteLine($"Nome do {cont}º Carro: {car}");

    cont++;
}
Console.WriteLine($"_________________________");
Console.ResetColor();