// Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário. 
// A     senha     válida     é     o     número     1234. 
// Devem     ser    impressas     as    seguintes     mensagens:
// ACESSO    PERMITIDO    caso    a    senha    seja    válida.
// ACESSO    NEGADO    caso    a    senha    seja    inválida.

string senha = "1234";

Console.Write("Digite a Senha: ");
string senhaDigitada = Console.ReadLine()!;

if (senhaDigitada == senha) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"SENHA CORRETA");
    Console.ResetColor();
}
else {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"SENHA INCORRETA");
    Console.ResetColor();
}