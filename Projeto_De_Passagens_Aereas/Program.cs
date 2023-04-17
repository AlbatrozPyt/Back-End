
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
        Console.Write(@$"
        ---------------------------------------
        Digite a senha de acesso do Sistema: 
        ---------------------------------------
    -> ");

        r = Console.ReadLine()!;
        Console.WriteLine(r == senha ? "SENHA CORRETA" : "SENHA INCORRETA");
        
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

Console.WriteLine($"");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine($"Entrando no sistema...");
Thread.Sleep(3000);

while (true) {
    Console.WriteLine($"");

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

    if (opcao == "1") {
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

        Console.Write("Digite a Data do Voo: ");
        data[cont] = Console.ReadLine()!;
        
        cont++;
    }

    else if (opcao == "2") {
        for (int i = 0; i != cont; i++) {
            Console.WriteLine($"Nome do passageiro: {nomes[i]}, Origem: {origem[i]}, Destino: {destino[i]}, Data do Voo: {data[i]};");
        }
    }

    else if (opcao == "0") {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("Finalizando programa");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Console.WriteLine($"");  
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            break;
}
}