Console.WriteLine(@$"
----------------------------------
            Jokenpô
----------------------------------
");

Console.WriteLine($"");

Console.Write($"Escreva Pedra, Papel ou Tesoura -> ");
string jogador = Console.ReadLine()!.ToUpper();


Random randNum = new Random();
int t = randNum.Next(1,4);

Console.WriteLine($"");

Console.BackgroundColor = ConsoleColor.Green;
Console.Write("JO");
Thread.Sleep(1000);

Console.BackgroundColor = ConsoleColor.Blue;
Console.Write("KEN");
Thread.Sleep(1000);

Console.BackgroundColor = ConsoleColor.Red;
Console.Write("PÔ");
Thread.Sleep(500);

Console.ResetColor();
Console.WriteLine($"");

Console.ForegroundColor = ConsoleColor.Green;
switch (t) {
    case 1:
    Console.WriteLine($"========================================");
    Console.WriteLine($"   COM: [PEDRA]  x  [{jogador}] :JOGADOR   ");
    Console.WriteLine($"========================================");
    if (jogador == "PEDRA") {
        Console.WriteLine($"EMAPATE !!!");
    }
    else if (jogador == "PAPEL") {
        Console.WriteLine($"GANHOU !!!");
    }
    else {
        Console.WriteLine($"PERDEU");
    }
    break;

    case 2:
    Console.WriteLine($"========================================");
    Console.WriteLine($"   COM: [PAPEL]  x  [{jogador}] :JOGADOR   ");
    Console.WriteLine($"========================================");
    if (jogador == "PAPEL") {
        Console.WriteLine($"EMAPATE !!!");
    }
    else if (jogador == "TESOURA") {
        Console.WriteLine($"GANHOU !!!");
    }
    else {
        Console.WriteLine($"PERDEU");
    }
    break;

    case 3:
    Console.WriteLine($"========================================");
    Console.WriteLine($"   COM: [TESOURA]  x  [{jogador}] :JOGADOR   ");
    Console.WriteLine($"========================================");
    if (jogador == "TESOURA") {
        Console.WriteLine($"EMAPATE !!!");
    }
    else if (jogador == "PEDRA") {
        Console.WriteLine($"GANHOU !!!");
    }
    else {
        Console.WriteLine($"PERDEU");
    }
    break;
}

Console.ResetColor();
