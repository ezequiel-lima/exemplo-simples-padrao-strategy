namespace CursoDesignPatterns
{
    public abstract class TemplateRelatorio
    {
        public string Imprimir(IList<Conta> contas)
        {
            if (TemMaisDeUmaConta(contas))
            {
                return RelatorioDeMuitasContas(contas);
            }

            return RelatorioDeUmaConta(contas);          
        }

        private bool TemMaisDeUmaConta(IList<Conta> contas)
        {
            if (contas.Count > 1)
                return true;

            return false;
        }

        protected abstract string RelatorioDeUmaConta(IList<Conta> contas);
        protected abstract string RelatorioDeMuitasContas(IList<Conta> contas);
        protected abstract string Cabecalho(IList<Conta> contas);
        protected abstract string Corpo(IList<Conta> contas);
        protected abstract string Rodape(IList<Conta> contas);
    }
}
