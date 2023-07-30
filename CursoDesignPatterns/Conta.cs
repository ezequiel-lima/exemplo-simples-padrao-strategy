namespace CursoDesignPatterns
{
    public class Conta
    {
        public Conta(string titular, string nomeDoBanco, double saldo, string endereco, string telefone, string email, string agencia, string numeroDaConta, DateTime dataAbertura)
        {
            Titular = titular;
            NomeDoBanco = nomeDoBanco;
            Saldo = saldo;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Agencia = agencia;
            NumeroDaConta = numeroDaConta;
            DataAbertura = dataAbertura;
        }

        public string Titular { get; private set; }
        public string NomeDoBanco { get; private set; }
        public double Saldo { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string Agencia { get; private set; }
        public string NumeroDaConta { get; private set; }
        public DateTime DataAbertura { get; private set; }
    }
}
