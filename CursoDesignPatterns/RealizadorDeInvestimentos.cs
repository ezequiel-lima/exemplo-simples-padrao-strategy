namespace CursoDesignPatterns
{
    public class RealizadorDeInvestimentos
    {
        public void RealizarInvestimento(ContaBancaria conta, IInvestimento investimento)
        {
            double result = investimento.RealizarInvestimento(conta);
            conta.Depositar(result);
            Console.WriteLine(result);
        }
    }
}
