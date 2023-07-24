namespace CursoDesignPatterns
{
    public class InvestimentoArrojado : IInvestimento
    {
        public double RealizarInvestimento(ContaBancaria conta)
        {
            int random = new Random().Next(1, 101);

            if (random <= 20)
            {
                return conta.Saldo * 0.05;
            }
            else if (random <= 50)
            {
                return conta.Saldo * 0.03;
            }

            return conta.Saldo * 0.006;
        }
    }
}
