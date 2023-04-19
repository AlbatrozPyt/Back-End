// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

using System.Globalization;


static void CadastrarProduto(string[] nomep, float[] precop, bool[] promo, int cont) {
    string p = "";
    float preco = 0F;
    string nome = "";

    Console.WriteLine($"");
    
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(@$"
    -=-=-=-=-=-=-=-=-=-=-=-=-=-=-
          CADASTRAR PRODUTO
    -=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    ");
    
    Console.WriteLine($"");
    
    Console.Write($"Nome do Produto: ");
    nome = Console.ReadLine()!;
    nomep[cont] = (nome);

    Console.Write($"Preço do Produto: ");
    preco = float.Parse(Console.ReadLine()!);
    precop[cont] = (preco);

    do { 
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"O produto esta em promoção ? [S/N]:  ");
        p = Console.ReadLine()!.ToUpper();
        if (p != "S" && p != "N") {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERRO, digite apenas S ou N.");
            Console.ResetColor();
        }
    } while (p != "S" && p != "N");

    if (p == "S") {
        promo[cont] = (true);
    }
    else if (p == "N") {
        promo[cont] = (false);
    }
    
    Console.ResetColor();
}

string[] nomeProduto = new string[10];
float[] precoProduto = new float[10];
bool[] promoProduto = new bool[10];
int cont = 0;
string opcao = "";

Console.WriteLine($"");

while (true) {
    Thread.Sleep(2000);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(@$"
    -=-=-=-=-=-=-=-=-=-=-=-=-=-=-

      GERENCIAMENTO DE PRODUTOS

    _____________________________

     0 - Sair
     1 - Cadastrar novo produto
     2 - Listar produto
    _____________________________

    -=-=-=-=-=-=-=-=-=-=-=-=-=-=-

    ");
    Console.Write($"Escolha uma opção: ");
    opcao = Console.ReadLine()!;
    Console.ResetColor();
    
     if (cont == 10 && opcao == "1") {
            Console.WriteLine($"");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Numero maximo de produtos cadastrados atingido !!!");
            Console.ResetColor();
            opcao = "2";
            Thread.Sleep(2000);
        }

    if (opcao == "1") {
        CadastrarProduto(nomeProduto, precoProduto, promoProduto, cont);
        Console.WriteLine($"");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"{cont+1} cadastro(s) de 10.");
        cont++;
        Console.ResetColor();
    }

    else if (opcao == "2") {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(@$"
        -=-=-=-=-=-=-=-=-=-=-=-=-=-=-
               LISTAR PRODUTOS
        -=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        ");
        for (int i = 0; i < cont; i++) {
            Console.WriteLine(@$"
            Nome do produto: {nomeProduto[i]}
            Preço do produto: {precoProduto[i].ToString("C", new CultureInfo("pt-BR"))} 
            Promoção: {promoProduto[i]} ({(promoProduto[i] == true ? "Com Promoção" : "Sem Promoção")})
            ");
        }
        Console.ResetColor();
    }

    else if (opcao == "0") {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Finalizando o sistema...");
        Console.ResetColor();
        Thread.Sleep(1000);
        Console.Clear();
        break;
    }
    else {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERRO, digite apenas as opções apresentadas !!!");
        Console.ResetColor();
    }
}    
