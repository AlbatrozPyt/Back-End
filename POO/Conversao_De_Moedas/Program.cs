// Exercício : Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
// Menu de opções : dólar para real, real para dólar, sair
// Personalizar a resposta, usando recursos da linguagem(Bibliotecas)
using Conversao_De_Moedas;

string opcao;
float valor;

while (true) {
    Console.WriteLine($"");

    do {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(@"
        -=-=-=-=-=-=-=-=-=-=-=-
        CONVERSOR DE MOEDAS
        -=-=-=-=-=-=-=-=-=-=-=-
        OPCAO:
            [1] - Dolar para Real
            [2] - Real para Dolar
            [0] -  Sair

        ");
        Console.Write("Escolha uma opcao: ");
        opcao = Console.ReadLine()!;
        Console.ResetColor();

        if (opcao != "1" && opcao != "2" && opcao != "0") {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"ERRO, digite apenas as opcoes do menu !!!");
            Console.ResetColor();
        }

    } while (opcao != "1" && opcao != "2" && opcao != "0");

    if (opcao == "1") {
    Console.WriteLine($"");
    
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Digite o valor em Dolar: $");
    valor = float.Parse(Console.ReadLine()!);
    Console.ResetColor();
    
    Console.WriteLine($"");
    
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"A conversao do valor é {ConversorMoedas.DolarToReal(valor)}");
    Console.ResetColor();
    }

    else if (opcao == "2") {
    Console.WriteLine($"");
    
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Digite o valor de Reais: R$");
    valor = float.Parse(Console.ReadLine()!);
    Console.ResetColor();
    
    Console.WriteLine($"");
    
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"A conversao do valor é {ConversorMoedas.RealToDolar(valor)}");
    Console.ResetColor();
}

    else if (opcao == "0") {
        Console.WriteLine($"");
        
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Finalizando...");
        Console.ResetColor();

        Thread.Sleep(1000);
        
        Console.Clear();
        break;
    }
}
