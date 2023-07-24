using CursoDesignPatterns;

IImposto iss = new ISS();
IImposto icms = new ICMS();

Orcamento orcamento = new Orcamento(500);

CalculadorImposto calculador = new CalculadorImposto();

calculador.RealizarCalculo(orcamento, iss);
calculador.RealizarCalculo(orcamento, icms);

Console.ReadKey();