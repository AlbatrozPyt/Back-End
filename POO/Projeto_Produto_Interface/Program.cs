using Projeto_Produto_Interface;

Carrinho  carrinho = new Carrinho(); // Instancia do objeto carrinho

Produto p1 = new Produto(1, "GTA V", 52.90f);
Produto p2 = new Produto(2, "Detroid Become Human", 120.50f);
Produto p3 = new Produto(3, "Forza", 100f);

Thread.Sleep(1000);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();

carrinho.TotalCarrinho();

carrinho.Remover(p2);

Thread.Sleep(3000);

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Apos a remocao de um item");
Console.ResetColor();

carrinho.Listar();

carrinho.TotalCarrinho();

carrinho.Remover(p3);

Thread.Sleep(3000);

Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Apos a remocao de um item");
Console.ResetColor();

carrinho.Listar();

carrinho.TotalCarrinho();

Thread.Sleep(3000);

Console.WriteLine($"Atualizando um Objeto");

Produto _novoProduto = new Produto();
_novoProduto.Nome = "FIFA 23";
_novoProduto.Preco = 300f;

carrinho.Atualizar(1, _novoProduto);

carrinho.Listar();

carrinho.TotalCarrinho();