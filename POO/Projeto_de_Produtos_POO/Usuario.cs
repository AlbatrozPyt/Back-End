namespace Projeto_de_Produtos_POO
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public DateTime DataDeCadastro { get; set; }

        // Metodos
        public void Cadastrar(Usuario _usuario) {
            Usuarios.Add(_usuario);
        }

        public void Deletar() {   
            Usuarios.Remove();
        }

        public void Listar() {
            foreach (var item in Usuarios)
            {
                Console.WriteLine(@$"
                -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                Usuario: {item.Nome}
                Codigo da Usuario: {item.Codigo} 
                Email: {item.Email}
                Senha: {item.Senha}
                -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                ");
            }
        }
    }
}