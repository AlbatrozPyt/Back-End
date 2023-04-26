namespace AulaPOO_Celular
{
    public class Celular
    {
        public string Cor;
        public string Modelo;
        public string Tamanho;
        public bool Ligado;

        // Metodos
        public void LigarCelular() {
            if (Ligado == true) {
                Console.WriteLine($"");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"O celular ja esta ligado !!!");
                Console.ResetColor(); 
            }
            else {
                Console.WriteLine($"");
                Ligado = true;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Celular Ligando...");
                Console.ResetColor();
                Thread.Sleep(1000);
            }
        }
        public void Telefonar() {
            Console.WriteLine($"");
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Numero de telefone: ");
            string telefone = Console.ReadLine()!;

            Console.WriteLine($"Ligando para {telefone} ...");
            Console.ResetColor();

            Thread.Sleep(2000);

            Console.BackgroundColor = ConsoleColor.DarkCyan; 
            Console.WriteLine($"Caixa Postal: Deixe a mensagem apos o sinal...");
            Console.ResetColor();
        }
        public void EscreverMsg() {
            Console.WriteLine($"");
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"Digite a mensagem: ");
            string mensagem = Console.ReadLine()!;
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Enviando mensagem...");
            Console.ResetColor();

            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($">>> ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(mensagem);
            Console.ResetColor();

            Console.WriteLine($"");
        }
        public void DesligarCelular() {
            if (Ligado == false) {
                Console.WriteLine($"");
                
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"O celular ja esta desligado !!!"); 
                Console.ResetColor();
            }
            else {
                Console.WriteLine($"");
                
                Ligado = false;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Celular Desligando...");
                Console.ResetColor();
                Thread.Sleep(1000);
            }
        }
        public void MostrarSistema() {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@$"
            -=-=-=-=-
            SISTEMA
            -=-=-=-=-
                COR: {Cor}
                MODELO: {Modelo}
                TAMANHO: {Tamanho}
            ");
            Console.ResetColor();
        }
    }

}