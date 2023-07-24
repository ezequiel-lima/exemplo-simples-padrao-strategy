namespace CursoDesignPatterns
{
    public class InvestimentoConservador : IInvestimento
    {
        public double RealizarInvestimento(ContaBancaria conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
