namespace CursoDesignPatterns
{
    public class ICMS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50;
        }
    }
}
