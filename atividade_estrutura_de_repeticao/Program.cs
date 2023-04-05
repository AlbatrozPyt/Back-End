string nome = "";
int idade = -1;
float salario = 0;
string e = "";
bool estadoCivil = false;

Console.WriteLine($"");

do {
    Console.BackgroundColor = ConsoleColor.Green;
    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine()!;
    Console.ResetColor();

    if (nome == "" || nome == " ") {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERRO, nome invalido !!!");
        Console.ResetColor();
    }

} while(nome == "");

Console.WriteLine($"");

do {
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Write("Digite sua idade: ");
    string i = Console.ReadLine()!;
    Console.ResetColor();

    if (i != "") {
        idade = int.Parse(i);
    }

    if (idade < 0 || idade > 100) {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERRO, idade invalida !!!");
        Console.ResetColor();
    }

} while(idade < 0 || idade > 100);

Console.WriteLine($"");

do {
    Console.BackgroundColor = ConsoleColor.White;
    Console.Write("Digite seu salario: ");
    salario = float.Parse(Console.ReadLine()!);
    Console.ResetColor();

    if (salario <= 0) {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERRO, salario invalida !!!");
        Console.ResetColor();
    }

} while(salario <= 0);

Console.WriteLine($"");

do {
    Console.BackgroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"Digite seu Estado Civil, [s]-Solteiro(a) [c]-Casado(a) [v]-Viuvo(a) [d]-Divorciado(a)");
    Console.Write("Opção: ");
    e = Console.ReadLine()!; 
    Console.ResetColor();

    if (e == "s" || e == "c" || e == "v" || e == "d") {
        estadoCivil = true;
    }
    else {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERRO, Estado Civil invalido !!!");
        Console.ResetColor();
    }

} while(estadoCivil == false);

Console.WriteLine($"");

Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Nome: {nome}, Idade: {idade} anos, Salario: R${Math.Round(salario, 2)} e Estado Civil: [{e}].");
Console.ResetColor();
