using CursoDesignPatterns;

//IImposto iss = new ISS();
//IImposto icms = new ICMS();
IImposto ihit = new IHIT();

Orcamento orcamento = new Orcamento(500);
orcamento.AdicionarItem(new("lapis", 500));
orcamento.AdicionarItem(new("LApist", 500));

CalculadorImposto calculador = new CalculadorImposto();

calculador.RealizarCalculo(orcamento, ihit);
//calculador.RealizarCalculo(orcamento, iccc);

//CalculadorDeDescontos calculadorDeDescontos = new CalculadorDeDescontos();

//double desconto = calculadorDeDescontos.Calcula(orcamento);
//Console.WriteLine(desconto);

Console.ReadKey();