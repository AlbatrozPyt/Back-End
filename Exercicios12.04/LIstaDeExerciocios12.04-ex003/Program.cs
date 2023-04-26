// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

using System.Globalization;

static float Desconto(float p, int q) {
    float desconto = 0;
    float total = p * q;

    if (q <= 5) {
        desconto = total - (total * 2 / 100);
    }
    else if (q > 5 && q <= 10) {
        desconto = total - (total * 3 / 100);
    }
    else {
        desconto = total - (total * 5  / 100);
    }
    
    return desconto;
}

Console.WriteLine($"");

Console.Write("Nome do Produto: ");
string produto = Console.ReadLine()!;

Console.WriteLine($"");

Console.Write($"Quantidade de {produto}: ");
int quant = int.Parse(Console.ReadLine()!);

Console.WriteLine($"");

Console.Write("Preco do Produto: ");
float preco = float.Parse(Console.ReadLine()!);

Console.WriteLine($"");

Console.WriteLine(@$"
PRODUTO: {produto}
QUANTIDADE: {quant}
PRECO: {Desconto(preco, quant).ToString("C", new CultureInfo("pt-BR"))};
");

