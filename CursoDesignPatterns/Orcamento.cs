using CursoDesignPatterns.State;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public IEstadoDeUmOrcamento EstudoAtual { get; set; } 
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }
        public bool DescontoJaAplicado { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstudoAtual = new EmAprovacao();
            DescontoJaAplicado = false;
        }

        public void AplicaDescontoExtra()
        {
            if (DescontoJaAplicado == true)
                throw new Exception("Desconto já foi Aplicado");

            EstudoAtual.AplicaDescontoExtra(this);
            DescontoJaAplicado = true;
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
