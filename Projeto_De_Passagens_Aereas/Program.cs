
// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).
string[] lista = new string[5];
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
static void Cadastrar()  {

    Console.WriteLine(@"=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    Console.WriteLine($"       Cadastro de Passagem      ");
    Console.WriteLine(@"=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

    Console.WriteLine($"");
    
    Console.Write("Nome do Passageiro: ");
    dados[0] = Console.ReadLine()!;


    Console.Write("Origem: ");
    dados[1] = Console.ReadLine()!;

    Console.Write("Destino: ");
    dados[2] = Console.ReadLine()!;
   

    Console.Write("Data do Voo -> d/mm/aaaa: ");
    dados[3] = Console.ReadLine()!;

    Console.WriteLine($"");

    Console.WriteLine(@"=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

    Console.WriteLine(@$"
    Nome do Passageiro: {dados[0]}
    Origem: {dados[1]};
    Destino: {dados[2]};
    Data do Voo: {dados[3]};
    ");
    
}

// Declarando Variaveis
string opcao = "";


// Login
EfetuarLogin();

Console.WriteLine($"");

while (true) {
    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    Console.WriteLine($"Entrando no sistema...");
    Thread.Sleep(3000);

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


    switch(opcao) {
        case "1":
        Cadastrar();
        break;

        case "2":
        break;

        case "0":
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