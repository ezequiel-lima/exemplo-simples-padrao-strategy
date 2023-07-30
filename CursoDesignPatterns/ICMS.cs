namespace CursoDesignPatterns
{
    public class ICMS : IImposto
    {
        public ICMS()
        {
        }

        public ICMS(IImposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return ((orcamento.Valor * 0.05) + 50) + CalculoDoOutroImposto(orcamento);
        }
    }
}
