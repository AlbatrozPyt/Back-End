// Atividade: 

// Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
// A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
// Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.

Console.WriteLine($"");

Console.WriteLine(@$"
          [Bebidas]
=============================
          COCA-COLA
          PEPSI
          SUCO
          MONSTER
=============================
");

Console.WriteLine($"");

Console.Write("Escolha uma das bebidas acima: ");
string bebida = Console.ReadLine()!.ToUpper();

switch (bebida) {
    case "COCA-COLA":
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"A bebida escolhida foi Coca-Cola.");
    break;

    case "PEPSI":
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"A bebida escolhida foi Pepsi.");
    break;

    case "SUCO":
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"A bebida escolhida foi Suco.");
    break;

    case "MONSTER":
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"A bebida escolhida foi Monster.");
    break;

    default:
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"Você não digitou a bebida corretamente. Então vai tomar Suco de Beterraba !!!");
    break;
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write($"Você quer acrescentar gelo na bebida ? [s/n] -> ");
    string gelo = Console.ReadLine()!.ToUpper();
    if (gelo == "S") {
        Console.WriteLine($"O gelo foi adicionado !!!");
    }
    else {
        Console.WriteLine($"A bebida é sem gelo !!!");
    }
Console.ResetColor();