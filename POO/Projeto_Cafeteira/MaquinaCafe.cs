namespace Projeto_Cafeteira
{
    public class MaquinaCafe
    {
        public float AcucarDisponivel { get; set; }

        // Metodos
        public void FazerCafe()
        {
            float acucar = 10;

            float gramas = this.AcucarDisponivel - acucar;

            Console.WriteLine($"");

            if (this.AcucarDisponivel <= 0) {
                Console.WriteLine($"O açucar acabou, então, apenas café sem açucar. ");
            }

            else {
                Console.Write("Fazendo Café...");
                Console.Beep(350, 200);
                Console.Beep(350, 200);
                Console.Beep(350, 200);

                Thread.Sleep(1000);

                Console.WriteLine($"Café Pronto");

                Console.WriteLine($"Adiconados {acucar}g de açucar.");
            }
        }

        public void FazerCafe(float acucar) {
            float gramas = this.AcucarDisponivel - acucar;

            if (this.AcucarDisponivel <= 0) {
                Console.WriteLine($"O açucar acabou, então, apenas café sem açucar. ");
            }
             else {
                Console.Write("Fazendo Café...");
                Console.Beep(350, 200);
                Console.Beep(350, 200);
                Console.Beep(350, 200);

                Thread.Sleep(1000);

                Console.WriteLine($"Café Pronto");

                Console.WriteLine($"Adiconados {acucar}g de açucar.");
            }
        }
    }
}
