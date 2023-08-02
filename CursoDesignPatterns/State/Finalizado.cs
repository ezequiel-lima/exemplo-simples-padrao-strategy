namespace CursoDesignPatterns.State
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados/finalizados nao recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está finalizado");
        }
    }
}
