// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

int cont = 1;
int mulheres = 0;
int homens = 0;
int numPess = 0;
string pessoas = "";
string sexo = "";

Console.WriteLine($"");

do {
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("Por favor, informe seu sexo [M/F]: ");
    sexo = Console.ReadLine()!.ToUpper();
    
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("Voce gostou do produto, Sim ou Nao: ");
    pessoas = Console.ReadLine()!.ToUpper();

    if (pessoas == "SIM") {
        numPess++;
    }

     if (sexo == "F" && pessoas == "SIM") {
        mulheres++;
    }

    if (sexo == "M" && pessoas == "NAO") {
        homens++;
    }

    Console.WriteLine($"");
    
    cont++;

} while(cont <= 10);

Console.WriteLine($"");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(@$"
                        -----------------------------                                            
                                    INFO                                                          
                        -----------------------------                                            
A -> Número de pessoas que responderam SIM: {numPess} pessoas                                    
B -> Número de pessoas que responderam NÃO: {10-numPess} pessoas                                 
C -> Número de mulheres que responderam SIM: {mulheres} mulheres                                 
D -> Porcentagem de homens que responderam NÃO entre todos os homens analisados. {homens*100/10}%
");
Console.ResetColor();