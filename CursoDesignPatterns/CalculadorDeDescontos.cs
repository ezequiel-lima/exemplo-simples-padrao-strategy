namespace CursoDesignPatterns
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto desconto1 = new DescontoPorCincoItens();
            IDesconto desconto2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto desconto3 = new DescontoPorVendaCasada();
            IDesconto desconto4 = new SemDesconto();

            desconto1.Proximo = desconto2;
            desconto2.Proximo = desconto3;
            desconto3 .Proximo = desconto4;

            //2 SOLUCAO **********************************************************************************************************
            ////
            //double desconto = new DescontoPorCincoItens().Calcula(orcamento);

            //if (desconto == 0)
            //    desconto = new DescontoPorMaisDeQuinhentosReais().Calcula(orcamento);

            //1 SOLUCAO **********************************************************************************************************
            //// mais de 5 itens
            //if (orcamento.Itens.Count > 5)
            //{
            //    return orcamento.Valor * 0.1;
            //}
            //else if (orcamento.Valor > 500)
            //{
            //    return orcamento.Valor * 0.07;
            //}

            return desconto1.Descontar(orcamento);
        }
    }
}
