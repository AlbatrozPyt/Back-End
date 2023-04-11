int[]numeros = new int[5];

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(@$"
======================
   DOBRO DO NUMEROS
======================
");
Console.ResetColor();

for (int i = 0; i < 5; i++) {
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.Write($"Digite o {i+1}º numero: ");
    Console.BackgroundColor = ConsoleColor.DarkRed;
    numeros[i] = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
}

Console.WriteLine($"");

foreach (int n in numeros)
{
    int dobro = n * 2;
    Console.ForegroundColor = ConsoleColor.Green; 
    Console.WriteLine($"O dobro de {n} é {dobro}.");
    Console.ResetColor();
   
}
