// 3.Crie uma classe abstrata para representar um jogador de futebol, com os atributos nome, data de nascimento, nacionalidade, altura e peso. Crie um método para imprimir todos os dados do jogador. Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.

using Desafio_Jogador;

JogadorAtaque atq = new JogadorAtaque();
JogadorMeioCampo mc = new JogadorMeioCampo();
JogadorDefesa def = new JogadorDefesa();
string opcao;


while (true) {
    Console.WriteLine($"");
    
    do {
        Console.WriteLine(@$"
        [ POSIÇÃO DO JOGADOR ]
        (1) - Ataque          
        (2) - Meio-Campo      
        (3) - Defesa          
        
        ");   
        Console.Write("Escolha uma opção: ");
        opcao = Console.ReadLine()!;

        if (opcao != "1" && opcao != "2" && opcao != "3") {
            Console.WriteLine($"");
            
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"ERRO, apenas as posições mostradas !!!");
            Console.ResetColor();
        }
    } while (opcao != "1" && opcao != "2" && opcao != "3");

    Console.WriteLine($"");
    
    Console.WriteLine(@$"
    [ Dados do Jogador ]
    ");
    
    if (opcao == "1") {
        Console.Write("Nome do Jogador: ");
        atq.Nome = Console.ReadLine()!;

        Console.WriteLine($"");
        
        Console.Write("Ano de Nascimento: ");
        atq.DataDeNascimento = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"");
        
        Console.Write("Nacionalidade: ");
        atq.Nacionalidade = Console.ReadLine()!;
        
        Console.WriteLine($"");
        
        Console.Write("Altura: ");
        atq.Altura = Console.ReadLine()!;
        
        Console.WriteLine($"");

        Console.Write("Peso: ");
        atq.Peso = Console.ReadLine()!;

        Console.WriteLine($"");
        
        atq.DadosJogador();
        atq.IdadeJogador();
        atq.Aposentadoria();
    }

    if (opcao == "2") {
        Console.Write("Nome do Jogador: ");
        mc.Nome = Console.ReadLine()!;

        Console.WriteLine($"");
        
        Console.Write("Ano de Nascimento: ");
        mc.DataDeNascimento = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"");
        
        Console.Write("Nacionalidade: ");
        mc.Nacionalidade = Console.ReadLine()!;
        
        Console.WriteLine($"");
        
        Console.Write("Altura: ");
        mc.Altura = Console.ReadLine()!;
        
        Console.WriteLine($"");

        Console.Write("Peso: ");
        mc.Peso = Console.ReadLine()!;

        Console.WriteLine($"");
        
        mc.DadosJogador();
        mc.IdadeJogador();
        mc.Aposentadoria();
    }

     if (opcao == "3") {
        Console.Write("Nome do Jogador: ");
        def.Nome = Console.ReadLine()!;

        Console.WriteLine($"");
        
        Console.Write("Ano de Nascimento: ");
        def.DataDeNascimento = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"");
        
        Console.Write("Nacionalidade: ");
        def.Nacionalidade = Console.ReadLine()!;
        
        Console.WriteLine($"");
        
        Console.Write("Altura: ");
        def.Altura = Console.ReadLine()!;
        
        Console.WriteLine($"");

        Console.Write("Peso: ");
        def.Peso = Console.ReadLine()!;

        Console.WriteLine($"");
        
        def.DadosJogador();
        def.IdadeJogador();
        def.Aposentadoria();
    }

    do {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write("Você quer cadastar mais um jogador [S/N] ? ");
        Console.ResetColor();
        opcao =Console.ReadLine()!.ToUpper();
        
        if (opcao != "S" && opcao != "N") {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"ERRO, apenas S ou N.");
            Console.ResetColor();
        }
    } while (opcao != "S" && opcao != "N");

    if (opcao == "N") {
        break;
    }
}