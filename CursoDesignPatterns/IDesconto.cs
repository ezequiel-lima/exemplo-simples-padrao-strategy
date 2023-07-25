namespace CursoDesignPatterns
{
    public interface IDesconto
    {
        public double Descontar(Orcamento orcamento);
        public IDesconto Proximo { get; set; }
    }
}
