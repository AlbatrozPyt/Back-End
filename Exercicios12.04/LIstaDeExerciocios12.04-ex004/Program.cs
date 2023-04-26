// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.

float[] num = new float[10];

for (int i = 0; i < 10; i++) {
    Console.Write($"Digite o {i+1}º Valor: ");
    num[i] = float.Parse(Console.ReadLine()!);

}

Array.Sort(num);

Console.WriteLine($"Dos valores digitados, o maior é {num[0]} e menor é {num[9]}.");
