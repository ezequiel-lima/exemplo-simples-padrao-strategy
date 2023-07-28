namespace CursoDesignPatterns
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            if (ExisteItemComMesmoNome(orcamento))          
                return true;          

            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        protected override double MinimaTaxaca(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.01) * orcamento.Itens.Count;
        }

        private bool ExisteItemComMesmoNome(Orcamento orcamento)
        {
            var nomeExistentes = new List<string>();

            foreach (var item in orcamento.Itens)
            {
                if (nomeExistentes.Contains(item.Nome.ToUpper()))
                {
                    return true;
                }
                else
                {
                    nomeExistentes.Add(item.Nome.ToUpper());
                }
            }

            return false;
        }
    }
}
