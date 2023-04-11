int[] numeros = new int [6];
int par = 0;
int impar = 0;

Console.WriteLine($"");

Console.ForegroundColor = ConsoleColor.Blue;
for (int c = 0; c < 6; c++) {
    Console.Write($"Digite o {c+1}º numero: ");
    numeros[c] = int.Parse(Console.ReadLine()!);
}
Console.ResetColor();

Console.WriteLine($"");

Console.ForegroundColor = ConsoleColor.DarkRed;
foreach (var n in numeros) {
    if (n % 2 == 0) {
        par++;
    }
    else {
        impar++;
    }
}
Console.WriteLine($"Sao {par} numeros par e {impar} numeros impar");
Console.ResetColor();