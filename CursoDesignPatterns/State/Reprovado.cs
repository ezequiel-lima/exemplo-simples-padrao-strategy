namespace CursoDesignPatterns.State
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados/finalizados nao recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está reprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstudoAtual = new Finalizado();
        }
    }
}
