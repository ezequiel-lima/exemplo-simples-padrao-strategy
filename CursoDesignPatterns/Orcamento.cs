using CursoDesignPatterns.State;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public IEstadoDeUmOrcamento EstudoAtual { get; set; } 
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstudoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            EstudoAtual.AplicaDescontoExtra(this);         
        }

        public void Aprova()
        {
            EstudoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstudoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstudoAtual.Finaliza(this);
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
