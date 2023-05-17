using Projeto_de_Produtos_POO;

namespace Projeto_de_Produtos_POO
{
    public class Login
    {
        public bool Logado { get; set; }
        public Login()
        {
            Marca _marca = new Marca();
            Produto _produto = new Produto();
            Usuario _usuario = new Usuario();

            _marca.Codigo = "100";
            _marca.NomeDaMarca = "Nike";
            _marca.DataDeCadastro = DateTime.Now;

            _produto.Codigo = "123";
            _produto.NomeDoProduto = "Air Max 90";
            _produto.Preco = 1000f;
            _produto.Marca = _marca;
            _produto.CadastradoPor = "Matheus";
            _produto.DataDeCadastro = DateTime.Now;

            _marca.Cadastrar(_marca);
            _marca.Listar();

            _produto.Cadastrar(_produto);
            _produto.Listar();

            _usuario.Codigo = 123;
            _usuario.Nome = "Matheus";
            _usuario.Email = "emaila@email";
            _usuario.Senha = "Pipoca";
            _usuario.DataDeCadastro = DateTime.Now;

            _usuario.Cadastrar(_usuario);
            _usuario.Listar();

            _usuario.Codigo = 321;
            _usuario.Nome = "Murillo";
            _usuario.Email = "emailb@email";
            _usuario.Senha = "Romeu";
            _usuario.DataDeCadastro = DateTime.Now;

            _usuario.Cadastrar(_usuario);
            _usuario.Listar();

            _usuario.Deletar(321);
            _usuario.Listar();
           
        }
    }
}