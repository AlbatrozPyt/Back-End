// 1. Crie uma classe denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
// no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
// presentes nele. A classe deve também disponibilizar os seguintes métodos:

// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// andares no prédio (os elevadores sempre começam no térreo e vazio);
// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);
// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);
// Subir : para subir um andar (não deve subir se já estiver no último andar);
// Descer : para descer um andar (não deve descer se já estiver no térreo);
// Encapsular todos os atributos da classe (criar os métodos set e get).

using Projeto_Elevador;

Elevador pess = new Elevador();
string opcao = "";

Console.WriteLine($"");

Console.BackgroundColor = ConsoleColor.DarkRed;
Console.WriteLine(@$"
Inicializando Elevador...
");
Console.ResetColor();

Thread.Sleep(1000);

Console.WriteLine($"");

Console.BackgroundColor = ConsoleColor.White;
Console.Write("Informe a capacidade do elevador: ");
pess.CapacidadeElevador = int.Parse(Console.ReadLine()!);
Console.ResetColor();

Console.WriteLine($"");

Console.BackgroundColor = ConsoleColor.White;
Console.Write("Informe o nº de andares: ");
pess.TotalAndares = int.Parse(Console.ReadLine()!);
Console.ResetColor();

Console.WriteLine($"");

while (true) {
    pess.Inicializar(pess.CapacidadeElevador, pess.TotalAndares);
    
    Thread.Sleep(1000);

    do {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($@"
        -=-=-=-=-=-=-=-=-=-=-=-
        OPCOES:
                [1] - Entrar
                [2] - Sair
                [3] - Subir
                [4] - Descer
                [0] - Fechar Elevador
        -=-=-=-=-=-=-=-=-=-=-=-

        ");
        Console.Write("Escolha uma opcao: ");
        opcao = Console.ReadLine()!;
        Console.ResetColor();

        if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "0") {
            Console.WriteLine($"");
            
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"ERRO, apenas as opcoes do menu !!!");
            Console.ResetColor();

            Thread.Sleep(1000);
        }
    } while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "0");

    Console.WriteLine($"");

    if (opcao == "1") {
        pess.Entrar();
        Thread.Sleep(1000);
    }

    else if (opcao == "2") {
        pess.Sair();
        Thread.Sleep(1000);
    }

    else if (opcao == "3") {
        pess.Subir();
    }

    else if (opcao == "4") {
        pess.Descer();
    }

    else if (opcao == "0") {
        Console.WriteLine($"");
        
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Finalizando Programa...");
        Console.ResetColor();

        Thread.Sleep(1000);

        Console.Clear();

        break;
    }
}