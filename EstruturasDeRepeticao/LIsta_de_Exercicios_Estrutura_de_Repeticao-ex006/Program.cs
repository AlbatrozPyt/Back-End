// 6. Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

Console.WriteLine(@$"
=================
     TABUADA
=================
");

Console.WriteLine($"");


for(int n1 = 1; n1 <= 10; n1++) {

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(@$"
    TABUADA DO {n1}
    ---------------
    ");

    Console.ForegroundColor = ConsoleColor.Green;
    for(int n2 = 0; n2 <= 10; n2++) {
        Console.WriteLine($"{n1} x {n2} = {n1*n2}");
    }
}
Console.ResetColor();