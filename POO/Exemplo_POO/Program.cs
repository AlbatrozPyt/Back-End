using Exemplo_POO;

List<Personagem> list = new List<Personagem>();
string opcao = "";

do
{   
    Console.WriteLine($"");
    
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(@$"
    =-==-==-==-==-==-==-==-==-==-=
        CRIAÇÃO DE PERSONAGENS
    =-==-==-==-==-==-==-==-==-==-=
    OPÇÕES:
      1 - Cadastrar personagem
      2 - Listar personagens
      0 - Fechar programa
    =-==-==-==-==-==-==-==-==-==-=
    ");
    Console.Write($"Escolha uma opção: ");
    opcao = Console.ReadLine()!;
    Console.ResetColor();
    
    while (opcao != "0" && opcao != "1" && opcao != "2")
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERRO, Digite apenas os valores do menu !!!");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write($"Escolha uma opção: ");
        opcao = Console.ReadLine()!;
        Console.ResetColor();
    }

    if (opcao == "1") {
        Console.WriteLine($"");
        
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(@$"
        =-==-==-==-==-==-==-==-==-==-=
            CADASTRO DE PERSONAGENS
        =-==-==-==-==-==-==-==-==-==-=
        ");
        
        Console.Write($"Informe o nome do personagem: ");
        string nome = Console.ReadLine()!;

        Console.Write($"Informe a idade do personagem: ");
        int idade = int.Parse(Console.ReadLine()!);

        Console.Write($"Informe a habilidade do personagem: ");
        string habilidade = Console.ReadLine()!;

        Console.WriteLine($"=-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-=");

        Console.ResetColor();
  
        list.Add(new Personagem(nome, idade, habilidade));
    }

    else if (opcao == "2") {
        Console.WriteLine($"");
        
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(@$"
        =-==-==-==-==-==-==-==-==-==-=
            PERSONAGENS CADASTRADOS
        =-==-==-==-==-==-==-==-==-==-=
        ");
        
        foreach (var item in list) {
            Console.WriteLine(item);
        }

        Console.WriteLine($"=-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-=");
        
        Console.ResetColor();
    }

    else {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"FINALIZANDO PROGRAMA...");
        Console.ResetColor();    
        Thread.Sleep(2000);
        Console.Clear();
        break;
    }

} while(true);

