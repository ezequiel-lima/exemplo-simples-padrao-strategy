namespace CursoDesignPatterns
{
    public class ImportoMuitoAlto : IImposto
    {
        public ImportoMuitoAlto() 
        {
        }

        public ImportoMuitoAlto(IImposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.2) + CalculoDoOutroImposto(orcamento);
        }
    }
}
