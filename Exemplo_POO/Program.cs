using Exemplo_POO;

Personagem p1 = new Personagem();
string opcao = "";
int cont = 0;

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
        List<Personagem> list = new List<Personagem>();
        
        Console.WriteLine($"");
        
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(@$"
        =-==-==-==-==-==-==-==-==-==-=
            CADASTRO DE PERSONAGENS
        =-==-==-==-==-==-==-==-==-==-=
        ");
        
        Console.Write($"Informe o nome do personagem: ");
        p1.nome = Console.ReadLine()!;

        Console.Write($"Informe a idade do personagem: ");
        p1.idade = int.Parse(Console.ReadLine()!);

        Console.Write($"Informe o armadura do personagem: ");
        p1.armadura = Console.ReadLine()!;

        Console.Write($"Informe a IA do personagem: ");
        p1.ia = Console.ReadLine()!;
        Console.WriteLine($"=-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-=");

        Console.ResetColor();
        
        cont++;
    }

    else if (opcao == "2") {
        Console.WriteLine($"");
        
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(@$"
        =-==-==-==-==-==-==-==-==-==-=
            PERSONAGENS CADASTRADOS
        =-==-==-==-==-==-==-==-==-==-=
        ");
        
        List<Personagem> list = new List<Personagem>();
        list.Add(p1);

        foreach (var item in list) {
        Console.WriteLine(@$"
        Nome do Personagem: {item.nome}
        Idade do Personagem: {item.idade}
        Armadura do Personagem: {item.armadura}
        IA do Personagem: {item.ia}
        ");
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

