namespace CursoDesignPatterns
{
    public class FiltrarContaMaiorQueQuinhentosReais : FIltro
    {
        public FiltrarContaMaiorQueQuinhentosReais()
        {
        }

        public FiltrarContaMaiorQueQuinhentosReais(FIltro outroFiltro) : base(outroFiltro)
        {
        }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            IList<Conta> contasFiltradas = contas.Where(x => x.Saldo > 500000).ToList();

            foreach (var contaFiltrada in AplicaOutroFiltro(contas))
            {
                contasFiltradas.Add(contaFiltrada);
            }

            return contasFiltradas;
        }
    }
}
