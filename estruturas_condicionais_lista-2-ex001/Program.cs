// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

Console.WriteLine();

Console.Write("Qual a dia do seu aniversario ? ");
int dia = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.Write("Qual o mês do seu aniversário ? ");
int mes = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.Write("Qual o ano do seu aniversário ? ");
int ano = int.Parse(Console.ReadLine()!);

Console.WriteLine();


if (dia > 31 || dia < 1) {
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine($"Dia invalido, o inicio do mes e no dia 1 e o final no dia 31 !!! ");
    Console.ResetColor();
}

else if (mes > 12 || mes < 1) {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Mes invalido, so tem de 1 a 12 meses !!!"); 
    Console.ResetColor();
}

else if (ano > 2013 || ano < 2013) {
    Console.WriteLine($"Ano invalido, estamos no ano de 2013.");
}

else {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Seu aniversario sera no dia {dia}/{mes}/{ano} !!!");
    Console.ResetColor();
}