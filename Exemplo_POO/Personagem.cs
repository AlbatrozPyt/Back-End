namespace Exemplo_POO
{
    public class Personagem
    {
        // Atributos
        public string nome;
        public int idade;
        public string armadura;
        public string ia;

        // Metodos
        public void Atacar() {
            Console.WriteLine($"O personagem Atacou !!!");
        }

        public void Defender() {
            Console.WriteLine($"O personagem Defendeu !!!");
        }

        public void RestaurarArmadura() {
            Console.WriteLine($"Armadura Restaurada !!!");
        }
    }
}