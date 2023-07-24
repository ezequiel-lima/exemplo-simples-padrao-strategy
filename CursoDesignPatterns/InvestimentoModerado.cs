namespace CursoDesignPatterns
{
    public class InvestimentoModerado : IInvestimento
    {
        public double RealizarInvestimento(ContaBancaria conta)
        {
            bool escolhido = new Random().Next(101) > 50;

            if (escolhido)
                return conta.Saldo * 0.025;

            return conta.Saldo * 0.007;
        }
    }
}
