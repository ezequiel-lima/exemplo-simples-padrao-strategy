using System.Drawing;

namespace CursoDesignPatterns.State
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstudoAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstudoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovacao nao pode ir para finalizado direto");
        }
    }
}
