namespace Projeto_de_Produtos_POO
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public DateTime DataDeCadastro { get; set; }

        // Metodos
        public void Cadastrar()
        {

            Usuario _usuario = new Usuario();
            Console.Write("Codigo: ");
            _usuario.Codigo = int.Parse(Console.ReadLine()!);

            Console.Write("Nome do Usuario: ");
            _usuario.Nome = Console.ReadLine()!;

            Console.Write("Email do Usuario: ");
            _usuario.Email = Console.ReadLine()!;

            Console.Write("Senha do Usuario: ");
            _usuario.Senha = Console.ReadLine()!;

            Usuarios.Add(_usuario);

        }

        public void Deletar(int c)
        {
            int user = Usuarios.FindIndex(x => x.Codigo == c);
            Usuarios.RemoveAt(user);
        }

        public void Listar()
        {
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