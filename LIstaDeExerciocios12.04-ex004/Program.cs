// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.

float num = 0;
float max = 0;
float min = 0;

for (int i = 0; i < 10; i++) {
    Console.Write($"Digite o {i+1}º Valor: ");
    num = float.Parse(Console.ReadLine()!);

    if (num >= max) {
        max = num;
    }

    if (num == 0) {}

    else if (num <= min) {
        min = num;
    }
    
}

Console.WriteLine($"Dos valores digitados, o maior é {max} e menor é {min}.");
