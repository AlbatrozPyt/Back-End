// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.

Console.WriteLine($"");

float[] numeros = new float[15];

for (int i = 0; i < 15; i++) {
    Console.Write($"Digite o {i+1}º numero: ");
    numeros[i] = float.Parse(Console.ReadLine()!);
}

Array.Reverse(numeros);

Console.WriteLine($"");

Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine($"A ordem inversa dos valores digitados é: ");

foreach (var item in numeros)
{
    Console.BackgroundColor = ConsoleColor.Green;
    Thread.Sleep(500);
    Console.Write($" {item} ");
    Console.ResetColor();
}
