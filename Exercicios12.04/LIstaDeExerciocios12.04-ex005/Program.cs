// 5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

Console.WriteLine(@$"
-------------------
     TABUADA

");

Console.WriteLine($"");

for (int x = 1; x <= 10; x++) {
    Console.WriteLine($"  TABUADA DO {x}");
    Console.WriteLine($"-------------------");
    for (int y = 0; y <= 10; y++) {
        Thread.Sleep(500);
        Console.WriteLine($"{x} x {y} = {x*y}");
    }
    Console.WriteLine($"-------------------");
    Console.WriteLine($"");
}
