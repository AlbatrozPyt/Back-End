// Faça um programa que leia três números e mostre o maior e o menor deles.

Console.WriteLine($"");

Console.Write("Digite um numero: ");
int n1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"");


Console.Write("Digite outro numero: ");
int n2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"");

Console.Write("Digite mais um numero: ");
int n3 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"");

if (n1 > n2 && n1 > n3) {
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"O numero {n1} e o maior !!!");
    Console.ResetColor();
}

else if (n2 > n1 && n2 > n3) {
   Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($"O numero {n2} e o maior !!!");
    Console.ResetColor();
}

else if (n3 > n1 && n3 > n2) {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"O numero {n3} e o maior !!!");
    Console.ResetColor();
}

Console.WriteLine($"");

if (n1 < n2 && n1 < n3) {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"O numero {n1} e o menor !!!");
    Console.ResetColor();
}

else if (n2 < n1 && n2 < n3) {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"O numero {n2} e o menor !!!");
    Console.ResetColor();
}

else if (n3 < n1 && n3 < n2) {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"O numero {n3} e o menor !!!");
    Console.ResetColor();
}