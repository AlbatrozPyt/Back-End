// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

Console.WriteLine($"DIgite o valor do salario recebido:");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Valor total gasto:");
float totalGasto = float.Parse(Console.ReadLine()!);

if (totalGasto > salario)
{
    Console.WriteLine($"Voce gastou um total de R${Math.Round(totalGasto, 2)}, 'Orçamento estourado'!!! ");
}
else {
    Console.WriteLine($"Voce gastou um total de R${Math.Round(totalGasto, 2)}, 'Gastos dentro do orçamento'!!! ");
}

