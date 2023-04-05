string nome = "";
int idade = -1;
float salario = 0;
string e = "";
bool estadoCivil = false;

do {
    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine()!;

    if (nome == "") {
        Console.WriteLine($"ERRO, nome invalido !!!");
    }

} while(nome == "");

do {
    Console.Write("Digite sua idade: ");
    string i = Console.ReadLine()!;

    if (i != "") {
        idade = int.Parse(i);
    }

    if (idade < 0 || idade > 100) {
        Console.WriteLine($"ERRO, idade invalida !!!");
    }

} while(idade < 0 || idade > 100);

do {
    Console.Write("Digite seu salario: ");
    salario = float.Parse(Console.ReadLine()!);

    if (salario <= 0) {
        Console.WriteLine($"ERRO, salario invalida !!!");
    }

} while(salario <= 0);

do {
    Console.WriteLine($"Digite seu Estado Civil, [s]-Solteiro(a) [c]-Casado(a) [v]-Viuvo(a) [d]-Divorciado(a)");
    Console.Write("Opção: ");
     e = Console.ReadLine()!; 

    if (e == "s" || e == "c" || e == "v" || e == "d") {
        estadoCivil = true;
    }

} while(estadoCivil == false);

Console.WriteLine($"");

Console.WriteLine($"Nome: {nome}, Idade: {idade} anos, Salario: R${Math.Round(salario, 2)} e Estado Civil: [{e}].");

