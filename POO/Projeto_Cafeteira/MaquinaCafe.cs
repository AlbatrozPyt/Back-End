namespace Projeto_Cafeteira
{
    public class MaquinaCafe
    {
        public float AcucarDisponivel { get; set; }

        // Metodos
        public void FazerCafe()
        {
            this.AcucarDisponivel -= 10;

            Console.WriteLine($"");

            if (this.AcucarDisponivel <= 0) {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"O açucar acabou, então, apenas café sem açucar. ");
                Console.ResetColor();

                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write("Fazendo Café");
                for (int i = 0; i < 3; i++) {
                    Console.Write(".");
                    Console.Beep(350, 500);
                    Thread.Sleep(1000);
                }

                Thread.Sleep(1000);

                Console.WriteLine($"Café Pronto");
                Console.ResetColor();
                Console.Beep(420, 300);
                
            }

            else {
                Console.WriteLine($"");
                
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write("Fazendo Café");
                for (int i = 0; i < 3; i++) {
                    Console.Write(".");
                    Console.Beep(350, 500);
                    Thread.Sleep(1000);
                }

                Thread.Sleep(1000);

                Console.WriteLine($"Café Pronto");
                Console.ResetColor();
                Console.Beep(420, 300);

                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Adiconados 10g de açucar.");

                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"Açucar Disponivel: {this.AcucarDisponivel}g.");

                Console.ResetColor();
                
            }
        }

        public void FazerCafe(float acucar) {

            if (this.AcucarDisponivel <= 0) {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"O açucar acabou, então, apenas café sem açucar. ");
                Console.ResetColor();
              
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write("Fazendo Café");
                for (int i = 0; i < 3; i++) {
                    Console.Write(".");
                    Console.Beep(350, 500);
                    Thread.Sleep(1000);
                }

                Thread.Sleep(1000);

                Console.WriteLine($"Café Pronto");
                Console.ResetColor();
                Console.Beep(420, 300);
            }
            
            else {
                Console.WriteLine($"");
                
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write("Fazendo Café");
                for (int i = 0; i < 3; i++) {
                    Console.Write(".");
                    Console.Beep(350, 500);
                    Thread.Sleep(1000);
                }

                Thread.Sleep(1000);

                Console.WriteLine($"Café Pronto");
                Console.ResetColor();
                Console.Beep(420, 300);

                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Adiconados {acucar}g de açucar.");
                
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"Açucar Disponivel: {this.AcucarDisponivel}g.");

                Console.ResetColor();
            }
        }
    }
}
