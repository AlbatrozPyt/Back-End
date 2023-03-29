//Faça um programa que receba o ano do nascimento de uma pessoa e calcule a idade dessa pessoa em anos
//e semanas e imprima o resultado no console.
//Observação: obter a data atual do sistema (Pesquisar na documentação)

Console.WriteLine($"Digite sua Data de Nascimento:");
int anoDeNascimento = int.Parse(Console.ReadLine());

int idade = DateTime.Today.Year - anoDeNascimento;

int semanas = idade * 52;

Console.WriteLine($"Voce tem {idade} anos e {semanas} semanas");
