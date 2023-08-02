namespace CursoDesignPatterns.State
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está em estado de aprovação");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstudoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {          
            orcamento.EstudoAtual = new Finalizado();
        }
    }
}
