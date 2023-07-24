namespace CursoDesignPatterns
{
    public class CalculadorImposto
    {
        public void RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            double resultado = imposto.Calcula(orcamento);
            Console.WriteLine(resultado);
        }
    }
}
