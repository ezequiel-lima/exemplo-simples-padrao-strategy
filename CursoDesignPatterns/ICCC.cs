namespace CursoDesignPatterns
{
    public class ICCC : IImposto
    {
        public ICCC()
        {
        }

        public ICCC(IImposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
            {
                return (orcamento.Valor * 0.05) + CalculoDoOutroImposto(orcamento);
            }
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
            {
                return (orcamento.Valor * 0.07) + CalculoDoOutroImposto(orcamento);
            }

            return ((orcamento.Valor * 0.08) + 30) + CalculoDoOutroImposto(orcamento);
        }
    }
}
