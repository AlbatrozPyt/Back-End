namespace Exemplo_POO
{
    public class Personagem
    {
        // Atributos
        public string Nome;
        public int Idade;
        public string Habilidade;

        public Personagem(string nome, int idade, string habilidade) {
            Nome = nome;
            Idade = idade;
            Habilidade = habilidade;
        }
        // Metodos
         public override string ToString()
        {
            return @$"
            Nome: {Nome}, Idade: {Idade}, Habilidade: {Habilidade}
            =-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-=
            ";
        }
    }
}