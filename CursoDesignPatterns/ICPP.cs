namespace CursoDesignPatterns
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP()
        {
        }

        public ICPP(IImposto outroImposto) : base(outroImposto)
        {
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            if (orcamento.Valor >= 500) 
                return true; 
            
            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double MinimaTaxaca(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
