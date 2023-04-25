// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.

using AulaPOO_Celular;

Celular cel = new Celular();
string opcao;

Console.WriteLine($"");

Console.Write("Cor do Celular: ");
cel.Cor = Console.ReadLine()!;

Console.WriteLine($"");

Console.Write("Modelo do Celular: ");
cel.Modelo = Console.ReadLine()!;

Console.WriteLine($"");

Console.Write("Tamanho do Celular: ");
cel.Tamanho = Console.ReadLine()!;

Console.WriteLine($"");

do {
    Console.Write("O celular esta ligado ? [S/N]: ");
    opcao = Console.ReadLine()!.ToUpper();
    
    if (opcao != "S" && opcao != "N") {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"ERRO, apenas S ou N.");
        Console.ResetColor();
    }

} while (opcao != "S" && opcao != "N");

cel.Ligado = opcao == "S" ? true : false;

Console.WriteLine($"");

while (true) {
    Console.WriteLine($"");
    
    do {

        if (cel.Ligado == true) {
            Console.WriteLine(@$"
            -=-=-=-=-=-=-=-=-=-=-=-=-=-=-
            Opcoes:
                    1 - Ligar Celular -> (APARELHO JA LIGADO)
                    2 - Fazer Ligacao
                    3 - Enviar Mensagem
                    4 - Desligar Celular
            ");
        }
        else {
    Console.WriteLine(@$"
    AVISO PARA MEXER NO CELULAR E PRECISO LIGA-LO !!!
    -=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    Opcoes:
            1 - Ligar Celular
            2 - Fazer Ligacao
            3 - Enviar Mensagem
            4 - Desligar Celular
            0 - Finalizar Programa
    ");
   } 
   
        Console.Write("Escolha uma opcao: ");
        opcao = Console.ReadLine()!;

        if (opcao != "0" && opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4") {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"ERRO, digite Apenas as opcoes do menu !!!");
            Console.ResetColor();
        }
   } while (opcao != "0" && opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4");


    if (opcao == "0") {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"FINALIZANDO PROGRAMA...");
        Console.ResetColor();
        Thread.Sleep(2000);
        break;
    }

    else if (opcao == "1") {
        if (cel.Ligado == true) {
            Console.WriteLine($"O celular ja esta ligado !!!"); 
        }
        else {
            cel.Ligado = true;
            Console.WriteLine($"Celular Ligando...");
            Thread.Sleep(1000);
        }
    }

}