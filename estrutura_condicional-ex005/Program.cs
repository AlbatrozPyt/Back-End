// As    maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

Console.Write("Quantas maçãs voce vai comprar? ");
int numMacas = int.Parse(Console.ReadLine()!);

if (numMacas >= 12) {
    float preco = (float)0.25 * numMacas;
    Console.WriteLine($"Voce comprou {numMacas} maçãs, R$0,25 cada, o total a pagar é R${Math.Round(preco, 2)}");
}
else {
     float preco = (float)0.30 * numMacas;
    Console.WriteLine($"Voce comprou {numMacas} maçãs, R$0,30 cada, o total a pagar é R${Math.Round(preco, 2)}");
}