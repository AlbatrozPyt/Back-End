// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.
 
// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

using Cadastro_de_Alunos_POO;

Aluno al = new Aluno();
string bolsa = "";

Console.WriteLine($"");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine(@$"
=-==-==-==-==-==-==-==-==-=
    CADASTRO DE ALUNO
=-==-==-==-==-==-==-==-==-=
");

Console.WriteLine($"");

Console.Write("Digite seu nome: ");
al.nome = Console.ReadLine()!;

Console.WriteLine($"");

Console.Write("Informe o Curso de interesse: ");
al.curso = Console.ReadLine()!;

Console.WriteLine($"");

Console.Write("Informe sua idade: ");
al.idade= int.Parse(Console.ReadLine()!);

Console.WriteLine($"");

Console.Write("Informe seu RG: ");
al.rg = Console.ReadLine()!.ToUpper();

Console.WriteLine($"");

do {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("Informe se é Bolsista:[S/N] ");
    bolsa = Console.ReadLine()!.ToUpper();

    if (bolsa != "S" && bolsa != "N") {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"ERRO, apenas S ou N.");
        Console.ResetColor();
    }

} while (bolsa != "S" && bolsa != "N");

if (bolsa == "S") {
    al.bolsista = true;
}

Console.WriteLine($"");

Console.Write("Informe sua Media Final: ");
al.mediaFinal = float.Parse(Console.ReadLine()!);

Console.WriteLine($"");

Console.Write("Informe o Valor da Mensalidade: ");
al.valorMensalidade = float.Parse(Console.ReadLine()!);

Console.ResetColor();

Console.WriteLine($"");

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(@$"
=-==-==-==-==-==-==-==-==-=
        INFORMACOES
=-==-==-==-==-==-==-==-==-=
1) Nome: {al.nome}
2) {al.VerMediaFinal()}
3) Idade: {al.idade}
4) RG: {al.rg}
5) Bolsa: {al.bolsista}
6) Media Final: {al.mediaFinal}
7) {al.VerMensalidade()}
");
Console.ResetColor();
