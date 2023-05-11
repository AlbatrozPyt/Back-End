namespace Projeto_Produto_Interface
{
    public class Carrinho : ICarrinho
    {
        public float Valor { get; set; }

        // Lista para manipular objetos
        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo)!.Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }

        public void Listar()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (carrinho.Count > 0)
            {
                foreach (Produto item in carrinho)
                {
                    Console.WriteLine(@$"
                    -=-=-=-=-=-=-=-=-=-=-=-=-
                    Codigo: [ {item.Codigo} ]
                    Nome: [ {item.Nome} ]
                    Preco: [ {item.Preco:C} ]
                    -=-=-=-=-=-=-=-=-=-=-=-=-
                    ");
                }
            }
            else
            {
                Console.WriteLine($"Carrinho Vazio");
            }
            Console.ResetColor();
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void TotalCarrinho()
        {
            Valor = 0;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (carrinho.Count > 0)
            {
                foreach (Produto item in carrinho)
                {
                    Valor += item.Preco;
                }
                Console.WriteLine($"Total do carrinho: [ {Valor:C} ]");
            }
            else
            {
                Console.WriteLine($"Carrinho Vazio");
            }
            Console.ResetColor();
        }
    }
}