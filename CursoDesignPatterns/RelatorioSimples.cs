using System.Text;

namespace CursoDesignPatterns
{
    public class RelatorioSimples : TemplateRelatorio
    {
        protected override string Cabecalho(IList<Conta> contas)
        {
            foreach (var conta in contas)
            {
                return $"{conta.NomeDoBanco}";
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
                return $"{conta.Telefone}";
            }

            return "Rodapé invalido";
        }

        protected override string RelatorioDeMuitasContas(IList<Conta> contas)
        {
            StringBuilder relatorio = new StringBuilder();

            foreach (var conta in contas)
            {
                relatorio.AppendLine($"TITULAR: {conta.Titular}, SALDO: {conta.Saldo}");
            }

            return relatorio.ToString();
        }

        protected override string RelatorioDeUmaConta(IList<Conta> contas)
        {
            StringBuilder relatorio = new StringBuilder();

            relatorio.AppendLine(Cabecalho(contas));
            relatorio.AppendLine(Corpo(contas));
            relatorio.AppendLine(Rodape(contas));

            return relatorio.ToString();
        }
    }
}
