// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

static string BuscaNome(string n, string[]p) {
    string r = "";
    foreach (var i in p) {
        if (i == n) {
             Console.ForegroundColor = ConsoleColor.Green;
             r =  $"Achei o nome {n} !!!";
             break;
        }
        else {
            Console.ForegroundColor = ConsoleColor.Red;
             r = $"O nome {n}, NÃO foi encontrado na lista.";
        }
    }
    return r;
}

string[] pessoas = new string [10];

Console.WriteLine($"");

for (int i = 0; i < 10; i++) {
    Console.Write($"Digite o {i+1}º nome: ");
    pessoas[i] = Console.ReadLine()!.ToUpper();
}

Console.WriteLine(@$"
----------
BUSCA NOME
----------
");

Console.Write("Escreva um nome para eu encontrar: ");
string busca = Console.ReadLine()!.ToUpper();

Console.WriteLine($"{BuscaNome(busca,pessoas)}");
 
Console.ResetColor();