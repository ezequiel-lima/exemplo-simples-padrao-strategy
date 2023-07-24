namespace CursoDesignPatterns
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }

        public ContaBancaria(double saldo)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
