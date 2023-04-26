// 2. Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

string senha = "";

Console.WriteLine($"");

Console.Write("Digite seu Nome: ");
string nome = Console.ReadLine()!.ToUpper();

Console.WriteLine($"Vamos criar uma senha !!!");

Console.WriteLine($"");

do {
    Console.Write("Digite uma Senha: ");
    senha = Console.ReadLine()!.ToUpper();
    
    if (nome == senha) {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERRO, a senha não pode ser seu nome !!!");
        Console.ResetColor();
    }

} while(nome == senha);

Console.WriteLine($"");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"A nova senha é {senha} !!!");
Console.ResetColor();
