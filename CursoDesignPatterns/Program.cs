using CursoDesignPatterns;

//IImposto iss = new ISS();
//IImposto icms = new ICMS();
//IImposto iccc = new ICCC();

Orcamento orcamento = new Orcamento(500);
orcamento.AdicionarItem(new("CANETA", 500));
orcamento.AdicionarItem(new("lapis", 500));

//CalculadorImposto calculador = new CalculadorImposto();

//calculador.RealizarCalculo(orcamento, iss);
//calculador.RealizarCalculo(orcamento, iccc);

CalculadorDeDescontos calculadorDeDescontos = new CalculadorDeDescontos();

double desconto = calculadorDeDescontos.Calcula(orcamento);
Console.WriteLine(desconto);

Console.ReadKey();