namespace CursoDesignPatterns
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        protected TemplateDeImpostoCondicional() : base()
        {
        }

        protected TemplateDeImpostoCondicional(IImposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
            }

            return MinimaTaxaca(orcamento) + CalculoDoOutroImposto(orcamento);
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxaca(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
    }
}
