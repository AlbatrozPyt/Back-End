// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

using System.Globalization;
static float Calculo(string c, float l) {
    float total = 0;
    float desconto = 0;

    switch(c) {
        case "G":
            total = l * 5.30F;
            if (l >= 20) {
                desconto = total - (total * 4 / 100);
            }
            else {
                desconto = total - (total * 6 / 100);
            }
            break;

        case "A":
            total = l * 4.90F;
            if (l >= 20) {
                desconto = total - (total * 3 / 100);
            }
            else {
                desconto = total - (total * 5 / 100);
            }
            break;
    }

    return desconto;
}

Console.Write(@"
--------------------------
 COMBUSTIVEIS |   PRECO
--------------------------
G - Gasolina  |  R$5,30l
A - Alcool    |  R$4,90l
--------------------------

Qual Combustivel vai querer ? -> ");
string combustivel = "";

do {
    combustivel = Console.ReadLine()!.ToUpper();
    if (combustivel != "G" && combustivel != "A" ) {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERRO, apenas G ou A !!!");
        Console.ResetColor();
    }
} while(combustivel != "G" && combustivel != "A" );

Console.WriteLine($"");

Console.Write("Quantos litros: ");
float litros = float.Parse(Console.ReadLine()!);

Console.WriteLine($"");

float d = Calculo(combustivel, litros);

Console.WriteLine(@$"
COMBUSTIVEL: {combustivel}
LITROS: {litros}
PRECO A PAGAR: {d.ToString("C", new CultureInfo("pt-BR"))}
");
