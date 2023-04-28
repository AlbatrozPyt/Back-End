namespace teste
{
    public class A
    {
        private float Limite = 10000f;

        //  Metodos
         public void Parcelar(float compra) {
            bool parcelar = false;
            string opcao;

            do {
            Console.Write("Voce quer parcelar no cartao:[S/N] ");
            opcao = Console.ReadLine()!;

            Console.WriteLine($"");
            
            if (opcao != "S" && opcao != "N") {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"ERRO, apenas S ou N");
                Console.ResetColor();
            }

            } while(opcao != "S" && opcao != "N");


            parcelar = opcao == "S" ? true : false;
         }

    }
} 