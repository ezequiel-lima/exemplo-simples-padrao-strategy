namespace CursoDesignPatterns
{
    public class FiltrarContaMenorQueCemReais : FIltro
    {
        public FiltrarContaMenorQueCemReais()
        {
        }

        public FiltrarContaMenorQueCemReais(FIltro outroFiltro) : base(outroFiltro)
        {
        }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            IList<Conta> contasFiltradas = contas.Where(x => x.Saldo < 100).ToList();

            foreach (var contaFiltrada in AplicaOutroFiltro(contas))
            {
                contasFiltradas.Add(contaFiltrada);
            }

            return contasFiltradas;
        }
    }
}
