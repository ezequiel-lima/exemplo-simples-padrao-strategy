namespace CursoDesignPatterns
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV()
        {
        }

        public IKCV(IImposto outroImposto) : base(outroImposto)
        {
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            if (orcamento.Valor > 500 && temItemMaiorQue100ReaisNo(orcamento)) 
                return true; 
            
            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double MinimaTaxaca(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
