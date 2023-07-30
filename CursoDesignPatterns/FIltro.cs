namespace CursoDesignPatterns
{
    public abstract class FIltro
    {
        protected FIltro(FIltro outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }

        protected FIltro()
        {
        }

        public abstract IList<Conta> Filtrar(IList<Conta> contas);
        public FIltro OutroFiltro { get; set; }

        protected IList<Conta> AplicaOutroFiltro(IList<Conta> contas)
        {
            if (OutroFiltro is null)
                return new List<Conta>();

            return OutroFiltro.Filtrar(contas);
        }
    }
}
