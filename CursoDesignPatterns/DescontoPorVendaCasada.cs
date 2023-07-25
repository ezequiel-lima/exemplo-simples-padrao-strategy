namespace CursoDesignPatterns
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            bool temLapis = orcamento.Itens.Any(x => "LAPIS".Equals(x.Nome.ToUpper()));
            bool temCaneta = orcamento.Itens.Any(x => "CANETA".Equals(x.Nome.ToUpper()));

            if (temCaneta && temLapis)
                return orcamento.Valor * 0.05;

            return Proximo.Descontar(orcamento);
        }
    }
}
