// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu). 

int anoAtual = DateTime.Now.Year;

Console.WriteLine($"");

Console.Write("Qual é seu ano de nascimento: ");
int anoDeNascimento = int.Parse(Console.ReadLine()!);

int idade = anoAtual - anoDeNascimento;

Console.WriteLine($"");

if (idade > 15 && idade < 18) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Voce tem {idade} anos, entao o voto é OPCIONAL.");
    Console.ResetColor();
}
else if (idade >= 18) {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Voce tem {idade} anos, entao o voto é OBRIGATORIO.");
    Console.ResetColor();
}
else {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Voce tem {idade} anos, entao voce NAO VOTA.");
    Console.ResetColor();
}

