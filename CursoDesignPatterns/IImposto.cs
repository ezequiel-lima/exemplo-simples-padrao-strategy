namespace CursoDesignPatterns
{
    public abstract class IImposto
    {
        protected IImposto(IImposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        protected IImposto()
        {
            OutroImposto = null;
        }

        public IImposto OutroImposto { get; set; }
        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto is null)           
                return 0;
            
            return OutroImposto.Calcula(orcamento);
        }
    }
}
