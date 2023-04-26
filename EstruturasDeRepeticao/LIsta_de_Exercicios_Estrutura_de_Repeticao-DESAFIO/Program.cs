// Pesquise como funciona o algoritmo Fibonacci.
// Faça um programa que gere a série até que o valor seja maior que 500. 

Console.WriteLine($"");

int numAtual = 1;
int num = 0;
int numAnterior = 0;

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Write($"Sequencia de Fibonacci:");

for(int i = 0; i <= 13; i++) {
    num = numAtual + numAnterior;
    numAnterior = numAtual;
    numAtual = num;

    Thread.Sleep(1000);
    
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.Write($" {num} ");
    Console.ResetColor();
}

// 0,1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610