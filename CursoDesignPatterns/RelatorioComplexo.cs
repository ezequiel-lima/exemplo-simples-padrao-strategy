using System.Text;

namespace CursoDesignPatterns
{
    public class RelatorioComplexo : TemplateRelatorio
    {
        protected override string RelatorioDeUmaConta(IList<Conta> contas)
        {
            StringBuilder relatorio = new StringBuilder();

            relatorio.AppendLine(Cabecalho(contas));
            relatorio.AppendLine(Corpo(contas));
            relatorio.AppendLine(Rodape(contas));

            return relatorio.ToString();
        }

        protected override string RelatorioDeMuitasContas(IList<Conta> contas)
        {
            StringBuilder relatorio = new StringBuilder();

            foreach (var conta in contas)
            {
                relatorio.AppendLine($"TITULAR: {conta.Titular}, AGENCIA: {conta.Agencia}, NUMERO: {conta.NumeroDaConta}, SALDO: {conta.Saldo}");
            }

            return relatorio.ToString();
        }

        protected override string Cabecalho(IList<Conta> contas)
        {
            foreach (var conta in contas)
            {
                return $"{conta.NomeDoBanco}, {conta.Endereco}, {conta.Telefone}";
            }

            return "Cabecalho invalido";
        }

        protected override string Corpo(IList<Conta> contas)
        {
            return "Corpo do relatorio";
        }

        protected override string Rodape(IList<Conta> contas)
        {
            foreach (var conta in contas)
            {
                return $"{conta.Email}, {conta.DataAbertura}";
            }

            return "Rodapé invalido";
        }
    }
}
