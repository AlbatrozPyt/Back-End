namespace Projeto_Produto_Interface
{
    public interface ICarrinho
    {
        // Regras do "Contrato"
        // Metodos que deveram ser apenas declarados

        // [C]reate
        void Adicionar(Produto _produto);

        // [R]ead
        void Listar();

        // [U]pdate
        void Atualizar(int _codigo, Produto _produto);

        // [D]elete
        void Remover(Produto _produto);
    }
}