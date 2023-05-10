//Criar um projeto
//Criar uma classe Carro: Marca, Cor;
//Criar um Construtor vazio e completo
//Receber dados no console para adicionar 2 objetos em uma lista
//Exibir os dois objetos da lista no Console

using Exercicio_lista_Carros;

Carro car = new Carro();
List<Carro> carros = new List<Carro>();

Console.WriteLine($"");

for (int i = 0; i < 2; i++) {
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Digite a {i+1}º Marca de carro: ");
    string m = Console.ReadLine()!;
    Console.ResetColor();

    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Digite a Cor: ");
    string c = Console.ReadLine()!;
    Console.ResetColor();

    Console.WriteLine($"");

    car = new Carro(m, c);
    carros.Add(car);
}

foreach (var item in carros)
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Marca do Carro [ {item.Marca} ] - Cor do Carro [ {item.Cor} ]");
    Console.ResetColor();
}