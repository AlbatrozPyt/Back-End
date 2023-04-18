
// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).


// Funcoes
static void EfetuarLogin() {
    string r = "";
    string senha = "11097";

    do {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(@$"
        ---------------------------------------
        Digite a senha de acesso do Sistema: 
        ---------------------------------------
    -> ");
        r = Console.ReadLine()!;
        Console.ResetColor();

        Console.WriteLine($"");
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(r == senha ? "SENHA CORRETA" : "SENHA INCORRETA");
        Console.ResetColor();
        
    } while(r != senha);
}

// Declarando Variaveis
int cont = 0;
string opcao = "";
string[] nomes = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];

// Login
EfetuarLogin();

Console.BackgroundColor = ConsoleColor.DarkRed;
Console.WriteLine($"");
Console.WriteLine($"Entrando no sistema...");
Thread.Sleep(3000);
Console.ResetColor();

while (true) {
    Console.WriteLine($"");

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(@$"
    =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            MENU DO SISTEMA

    OPCOES:
        -> 1 - Cadastrar Passagem
        -> 2 - Listar Passagens
        -> 0 - Sair
    =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    ");
    Console.Write($"Escolha uma opcao: ");
    opcao = Console.ReadLine()!;
    Console.ResetColor();

    if (opcao == "1") {
        string r = "";
        while(true) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@$"
            =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                    CADASTRO DE PASSAGEM
            =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            ");

            Console.Write("Digite seu nome: ");
            nomes[cont] = Console.ReadLine()!;

            Console.Write("Qual sua Origem: ");
            origem[cont] = Console.ReadLine()!;

            Console.Write("Digite seu destino: ");
            destino[cont] = Console.ReadLine()!;

            Console.Write("Digite a Data do Voo [d/mm/aaaa]: ");
            data[cont] = Console.ReadLine()!;
            
            cont++;

            Console.WriteLine($"");

            if (cont < 5) {
                Console.WriteLine($"Voce tem mais {5-cont} Cadastros !!!");
            }
            
            Console.Write("Você quer cadastrar uma nova pessoa [S/N]: ");
            r = Console.ReadLine()!.ToUpper();

            if (r != "S" && r != "N") {
                while (r != "S" && r != "N") {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"ERRO, Apenas S ou N !!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.Write("Você quer cadastrar uma nova pessoa [S/N]: ");
                    r = Console.ReadLine()!.ToUpper();

                    Console.ResetColor();
                }
            }
            if (r == "N") {
                break;
            }
            
            Console.ResetColor();
        }
    }

    else if (opcao == "2") {
        Console.WriteLine($"");
        
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(@"
        =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                Listando Cadastros
        =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        ");
        for (int i = 0; i != cont; i++) {        
            Console.WriteLine(@$"
            PASSAGEM {i+1}
            =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            Nome do passageiro: {nomes[i]} 
            Origem: {origem[i]} 
            Destino: {destino[i]}
            Data do Voo [d/mm/aaaa]: {data[i]}
            =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            ");
        }
        Console.ResetColor();
    }

    else if (opcao == "0") {
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Finalizando programa");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Console.ResetColor();
            Console.WriteLine($"");  
            Console.WriteLine("");
            break;
}
}
