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
    }
}