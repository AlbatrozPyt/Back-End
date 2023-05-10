using Exercicio_Construtor;

List<Produto> produtos = new List<Produto>();
Produto a = new Produto();

produtos.Add(new Produto(2563, "camiseta QuickSilver", 19.90f));

produtos.Add(new Produto(1025, "tenis Naiki", 50f));

a = new Produto(1536, "calca Diesel", 15f);
produtos.Add(a);

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Lista Antiga");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Magenta;
foreach (var item in produtos)
{
    Console.WriteLine($"");
    
    Console.WriteLine($"[ Codigo: {item.Codigo}, Nome: {item.Nome}, Preco: {item.Preco:C} ] - nº - {produtos.IndexOf(item)}");
}
Console.ResetColor();

Console.WriteLine($"");

Produto produtoBuscado = produtos.Find(x => x.Codigo == 2563)!; // Busca um objeto na lista

int index = produtos.IndexOf(produtoBuscado);

produtoBuscado.Preco = 199.90f;

produtos.RemoveAt(index);

produtos.Insert(index, produtoBuscado);

Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Lista Nova");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
foreach (var item in produtos)
{
    Console.WriteLine($"");
    
    Console.WriteLine($"[ Codigo: {item.Codigo}, Nome: {item.Nome}, Preco: {item.Preco:C} ] - nº - {produtos.IndexOf(item)}");

    Console.WriteLine($"");
}
Console.ResetColor();
