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

           for (int i = 0; i < 3; i++)
           {
            _produto.Cadastrar();
           }
           _produto.Listar();

           _produto.Deletar(3);

           _produto.Listar();
        }

        // LOGAR
        public void Logar()
        {
            Usuario _usuario = new Usuario();
            string email;
            string senha;

            Console.WriteLine($"");

            if (Logado == false)
            {
                do
                {
                    Console.Write("Digite seu Email: ");
                    email = Console.ReadLine()!;

                    Console.Write("Digite sua senha: ");
                    senha = Console.ReadLine()!;

                    if (email != _usuario.Email && senha != _usuario.Senha)
                    {
                        Console.WriteLine($"");

                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"ERRO, email ou senha errados !!!");
                        Console.ResetColor();

                        Console.WriteLine($"");
                    }

                } while (email != _usuario.Email && senha != _usuario.Senha);
                Console.WriteLine($"Voce fez o login.");
                
            }
            else
            {
                Console.WriteLine($"Voce ja esta logado !!!");
            }
            Logado = true;
        }

        public void Deslogar()
        {
            Usuario _usuario = new Usuario();
            string email;
            string senha;

            Console.WriteLine($"");

            if (Logado == true)
            {
                do
                {
                    Console.Write("Digite seu Email: ");
                    email = Console.ReadLine()!;

                    Console.Write("Digite sua senha: ");
                    senha = Console.ReadLine()!;

                    if (email != _usuario.Email && senha != _usuario.Senha)
                    {
                        Console.WriteLine($"");

                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"ERRO, email ou senha errados !!!");
                        Console.ResetColor();

                        Console.WriteLine($"");
                    }

                } while (email != _usuario.Email && senha != _usuario.Senha);
                Console.WriteLine($"Voce fez o logout.");
            }
            else
            {
                Console.WriteLine($"Voce ja esta deslogado !!!");
            }
            Logado = false;
        }
    }
}
