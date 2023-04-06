// 3. Faça um programa que receba um número inteiro e mostre a sua tabuada.

Console.WriteLine($"");

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Digite um numero inteiro: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"A tabuada do {num} é: ");

for(int multi = 0; multi <= 10; multi++) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"  {num} x {multi} = {num*multi} ");
    Console.ResetColor();
}
