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
            string opcao;
            int c;

            while (true)
            {
                if (this.Logado == false)
                {
                    string email;
                    string senha;

                    do
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(@$"
                    -=-=-=-=-=-=-
                        LOGIN
                    -=-=-=-=-=-=-
                    ");

                        Console.Write("Digite o email do usuario: "); //  Email: email@email
                        email = Console.ReadLine()!;

                        Console.Write("Digite a senha do usuario: "); // Senha: 1234
                        senha = Console.ReadLine()!;

                        if (email != _usuario.Email || senha != _usuario.Senha)
                        {
                            Console.WriteLine($"");

                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"ERRO, email ou senha ERRADOS !!!");
                            Console.ResetColor();
                        }

                    } while (email != _usuario.Email || senha != _usuario.Senha);
                    Console.ResetColor();
                    Logado = true;
                }

                Console.WriteLine($"");


                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@$"
                -=-=-=-=-=-=-=-=-=-=-=-
                1 - Adicionar Produto
                2 - Listar Produto
                3 - Remover Produto
                ------------------------
                4 - Adicionar Marca
                5 - Listar Marca
                6 - Remover Marca
                ------------------------
                0 - Sair
                -=-=-=-=-=-=-=-=-=-=-=-
                ");
                    Console.Write("Escolha uma opcao: ");
                    opcao = Console.ReadLine()!;

                    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6" && opcao != "0")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"ERRO, digite apenas as opcoes do menu !!!");
                        Console.ResetColor();
                    }
                } while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6" && opcao != "0");
                Console.ResetColor();

                if (opcao == "0")
                {
                    Console.WriteLine($"");

                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"FINALIZANDO...");
                    Console.ResetColor();

                    Thread.Sleep(1000);

                    Console.Clear();
                    break;
                }

                if (opcao == "1")
                {
                    Console.WriteLine($"");

                    _produto.Cadastrar();
                    Thread.Sleep(1000);
                }

                else if (opcao == "2")
                {
                    Console.WriteLine($"");

                    _produto.Listar();
                    Thread.Sleep(1000);
                }

                else if (opcao == "3")
                {
                    Console.WriteLine($"");

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Digite o codigo do produto que quer remover: ");
                    c = int.Parse(Console.ReadLine()!);
                    Console.ResetColor();

                    _produto.Deletar(c);
                    Thread.Sleep(1000);
                }

                else if (opcao == "4")
                {
                    Console.WriteLine($"");

                    _marca.Cadastrar();
                    Thread.Sleep(1000);
                }

                else if (opcao == "5")
                {
                    Console.WriteLine($"");

                    _marca.Listar();
                    Thread.Sleep(1000);
                }

                else if (opcao == "6")
                {
                    Console.WriteLine($"");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Digite o codigo da marca que quer remover: ");
                    c = int.Parse(Console.ReadLine()!);
                    Console.ResetColor();

                    _marca.Deletar(c);
                    Thread.Sleep(1000);
                }

            }
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
