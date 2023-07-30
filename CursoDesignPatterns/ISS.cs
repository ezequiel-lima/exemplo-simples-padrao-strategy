namespace CursoDesignPatterns
{
    public class ISS : IImposto
    {
        public ISS() 
        {
           
        }

        public ISS(IImposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }       
    }
}
