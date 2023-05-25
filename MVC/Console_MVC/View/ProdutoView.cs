using Console_MVC.Model;

namespace Console_MVC.View
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine(@$"
                Codigo: {item.Codigo}
                Nome: {item.Nome}
                Preço: {item.Preco:C}
                ");
            }
        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.Write($"Informe o Codigo: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);

            Console.Write($"Informe o Nome do Produto: ");
            novoProduto.Nome = Console.ReadLine()!;

            Console.Write($"Informe o Preco: ");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);

            return novoProduto;
        }
    }
}