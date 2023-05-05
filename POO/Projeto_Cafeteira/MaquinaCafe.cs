namespace Projeto_Cafeteira
{
    public class MaquinaCafe
    {
        public float AcucarDisponivel {get; set;} = 100;

        // Metodos
        public void FazerCafe() {
            bool r;
            string op = "";
            float acucar = 0;

            Console.WriteLine($"");
            
            do {
                Console.Write("Digite quantas Gramas de acucar vai querer: ");
                op = Console.ReadLine()!;

                r = float.TryParse(op, out acucar); 

                if (r == true) {
                    acucar = float.Parse(op);
                }
                else if (op == "") {
                    acucar = 10;
                }
                else {
                    Console.WriteLine($"");
                    
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"ERRO, digite apenas numeros !!!");
                    Console.ResetColor();
                }

                
            } while (r == false);
        }
    }
}