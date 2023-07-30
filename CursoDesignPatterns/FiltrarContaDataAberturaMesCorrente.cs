namespace CursoDesignPatterns
{
    public class FiltrarContaDataAberturaMesCorrente : FIltro
    {
        public FiltrarContaDataAberturaMesCorrente()
        {
        }

        public FiltrarContaDataAberturaMesCorrente(FIltro outroFiltro) : base(outroFiltro)
        {
        }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            DateTime primeiroDiaDoMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime ultimoDiaDoMes = primeiroDiaDoMes.AddMonths(1).AddDays(-1);

            List<Conta> contasFiltradas = new List<Conta>();
            foreach (var conta in contas)
            {
                if (conta.DataAbertura >= primeiroDiaDoMes && conta.DataAbertura <= ultimoDiaDoMes)
                {
                    contasFiltradas.Add(conta);
                }
            }

            foreach (var contaFiltrada in AplicaOutroFiltro(contas))
            {
                contasFiltradas.Add(contaFiltrada);
            }

            return contasFiltradas;
        }
    }
}
