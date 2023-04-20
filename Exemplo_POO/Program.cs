using Exemplo_POO;

Personagem p1 = new Personagem();

do
{
    Console.Write($"Informe o nome do personagem: ");
    p1.nome = Console.ReadLine()!;

    Console.Write($"Informe a idade do personagem: ");
    p1.idade = int.Parse(Console.ReadLine()!);

    Console.Write($"Informe o armadura do personagem: ");
    p1.armadura = Console.ReadLine()!;

    Console.Write($"Informe a IA do personagem: ");
    p1.ia = Console.ReadLine()!;

    List<Personagem> list = new List<Personagem>();
    list.Add(p1);
} while(true);

foreach (var item in list)
{
    Console.WriteLine(@$"
    Nome do Personagem: {item.nome}
    Idade do Personagem: {item.idade}
    Armadura do Personagem: {item.armadura}
    IA do Personagem: {item.ia}
    ");
}
