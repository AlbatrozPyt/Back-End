// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:

// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.

int homens = 0;
int mulheres = 0;
int idade = 0;
int idadeM = 0;
int idadeF = 0;
string sexo = "";
int cont = 1;

Console.WriteLine($"");

do
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("Digite sua idade: ");
    idade = int.Parse(Console.ReadLine()!);

    Console.Write("Digite seu peso: ");
    float peso = float.Parse(Console.ReadLine()!);
    
    Console.Write("Informe seu sexo [M/F]: ");
    sexo = Console.ReadLine()!.ToUpper();

    if (sexo == "M") {
        homens++;
        idadeM += idade;
    }
    else {
        mulheres++;
        idadeF += idade;
    }
    
    Console.WriteLine($"");
    
    cont++;

} while(cont <= 10);

Console.WriteLine($"");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@$"
-------------------------
          INFO
-------------------------
A -> Total de Homens: {homens} homens
B -> Total de Mulheres: {mulheres} mulheres
C -> Média de idade dos Homens: {idadeM/homens} anos
D -> Média de idade dos Mulheres: {idadeF/mulheres} anos
");
Console.ResetColor();
