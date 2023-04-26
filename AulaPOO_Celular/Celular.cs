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
            Console.WriteLine($"O celular ja esta ligado !!!"); 
            }
            else {
                Ligado = true;
                Console.WriteLine($"Celular Ligando...");
                Thread.Sleep(1000);
            }
        }
        public void Telefonar() {
            Console.Write("Numero de telefone: ");
            string telefone = Console.ReadLine()!;

            Console.WriteLine($"Ligando...");
            
            Thread.Sleep(2000);

            Console.WriteLine($"Caixa Postal: Deixe a mensagem apos o sinal...");
        }
        public void EscreverMsg() {
            Console.Write($"Digite a mensagem: ");
            string mensagem = Console.ReadLine()!;
            
            Console.WriteLine($"Enviando mensagem...");
            
            Console.WriteLine($">>> {mensagem}");
        }
        public void DesligarCelular() {
            if (Ligado == false) {
            Console.WriteLine($"O celular ja esta desligado !!!"); 
            }
            else {
                Ligado = false;
                Console.WriteLine($"Celular Desligando...");
                Thread.Sleep(1000);
            }
        }
        public void MostrarSistema() {
            Console.WriteLine(@$"
            -=-=-=-=-
            SISTEMA
            -=-=-=-=-
            COR: {Cor}
            MODELO: {Modelo}
            TAMANHO: {Tamanho}
            ");
        }
    }

}