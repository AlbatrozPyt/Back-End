// Nesta aula vamos fazer um pequeno sistema de calculadora, em um projeto de console no VsCode.

// Vamos desenvolver um programa orientado a objeto que faça as 4 operações matemáticas.

// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.

using POO_Calculadora;

Calculadora num = new Calculadora();
string opcao = "";



while (true) {
    do {
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(@$"
    -=--=--=--=--=--=--=--=--=--=-
            CALCULA TUDO
    -=--=--=--=--=--=--=--=--=--=-
    Opcoes:
            1 - Adicao
            2 - Subtracao
            3 - Multiplicacao
            4 - Divisao
    -=--=--=--=--=--=--=--=--=--=-
    ");
    Console.Write("Escolha uma opcao: ");
    opcao = Console.ReadLine()!;
    Console.ResetColor();
    
    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4") {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERRO, apenas as opcoes do menu.");
        Console.ResetColor();
    }

    } while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4");

    Console.WriteLine($"");

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("Digite o 1º numero: ");
    num.num1 = float.Parse(Console.ReadLine()!);

    Console.Write("Digite outro numero: ");
    num.num2 = float.Parse(Console.ReadLine()!);
    Console.ResetColor();

    if (opcao == "1") {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(@$"
        -=--=--=--=--=--=--=--=--=--=-
                    SOMA
        -=--=--=--=--=--=--=--=--=--=-
        ");

        Console.WriteLine($"{num.num1} + {num.num2} = {num.Somar()}");
        Console.ResetColor();
    }

    else if (opcao == "2") {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(@$"
        -=--=--=--=--=--=--=--=--=--=-
                SUBTRACAO
        -=--=--=--=--=--=--=--=--=--=-
        ");

        Console.WriteLine($"{num.num1} - {num.num2} = {num.Subtrair()}");
        Console.ResetColor();
    }

    else if (opcao == "3") {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(@$"
        -=--=--=--=--=--=--=--=--=--=-
                MULTIPLICACAO
        -=--=--=--=--=--=--=--=--=--=-
        ");

        Console.WriteLine($"{num.num1} X {num.num2} = {num.Multiplicar()}");
        Console.ResetColor();
    }

    else if (opcao == "4") {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(@$"
    -=--=--=--=--=--=--=--=--=--=-
               DIVISAO
    -=--=--=--=--=--=--=--=--=--=-
    ");

    Console.WriteLine($"{num.num1} / {num.num2} = {num.Dividir()}");
    Console.ResetColor();
}

    do {
        Console.WriteLine($"");
        
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("Voce quer continuar:[S/N] ");
        opcao = Console.ReadLine()!.ToUpper(); 
        Console.ResetColor();

        if (opcao != "S" && opcao != "N") {
            Console.WriteLine($"");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERRO, apenas S ou N.");
            Console.ResetColor();
        }

    } while (opcao != "S" && opcao != "N");

    if (opcao == "N") {
        Console.WriteLine($"");
        
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"FINALIZANDO...");
        Console.ResetColor();
        Thread.Sleep(2000);
        break;
    }
}


