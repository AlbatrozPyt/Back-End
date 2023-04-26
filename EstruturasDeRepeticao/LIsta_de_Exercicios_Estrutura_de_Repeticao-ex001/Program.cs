// 1. Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

float nota = 0;

Console.WriteLine($"");

do {
    Console.Write("Digite uma nota: ");
    nota = float.Parse(Console.ReadLine()!);
    
    if (nota < 0 || nota > 10) {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERRO, a nota tem que estar entre 0 e 10 !!!");
        Console.ResetColor();
    }
} while(nota < 0 || nota > 10);