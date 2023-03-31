// Faça um programa que verifique se uma letra digitada é vogal ou consoante
Console.WriteLine($"");

Console.Write("Digite qualquer letra: ");
string letra = Console.ReadLine()!.ToUpper();

Console.WriteLine($"");

if (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U") {
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"A letra {letra}, é uma vogal");
    Console.ResetColor();
}
else {
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"A letra {letra}, é uma consoante.");
    Console.ResetColor();
}