string[] nomes = new string[5];
int[] idade = new int[5];

Console.WriteLine($"");

for (int i = 0; i < 5; i++) {
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Write("Digite seu nome: ");
    nomes[i] = Console.ReadLine()!;
    Console.ResetColor();

    Console.BackgroundColor = ConsoleColor.Green;
    Console.Write("Digite sua idade: ");
    idade[i] = int.Parse(Console.ReadLine()!);

    Console.ResetColor();
    Console.WriteLine($"");
}

Console.WriteLine($"");

for (int r = 0; r < 5; r++) {
    Console.WriteLine($"");
    
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{r+1})");
    Console.ResetColor();
    
    Console.Write("Nome: ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write($"{nomes[r]}");
    Console.ResetColor();

    Console.WriteLine($"");
    
    Console.Write("Idade: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{idade[r]} anos");
    Console.ResetColor();

    Console.WriteLine($"");
}

    