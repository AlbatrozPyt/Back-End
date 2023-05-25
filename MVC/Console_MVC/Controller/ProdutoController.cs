using Console_MVC.Model;
using Console_MVC.View;

namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();
            produtoView.Listar(produtos);
        }

        public void CadastrarProdutos()
        {

            ProdutoView pw = new ProdutoView();
            Produto p = new Produto();

            p.Inserir(pw.Cadastrar());

        }
    }
}