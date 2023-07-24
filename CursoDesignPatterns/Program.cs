using CursoDesignPatterns;

IImposto iss = new ISS();
IImposto icms = new ICMS();
IImposto iccc = new ICCC();

Orcamento orcamento = new Orcamento(10000);

CalculadorImposto calculador = new CalculadorImposto();

//calculador.RealizarCalculo(orcamento, iss);
//calculador.RealizarCalculo(orcamento, iccc);

IInvestimento conservador = new InvestimentoConservador();
IInvestimento moderado = new InvestimentoModerado();
IInvestimento arrojado = new InvestimentoArrojado();

ContaBancaria conta = new ContaBancaria(100);

RealizadorDeInvestimentos realizadorDeInvestimentos = new RealizadorDeInvestimentos();

realizadorDeInvestimentos.RealizarInvestimento(conta, conservador);
realizadorDeInvestimentos.RealizarInvestimento(conta, moderado);
realizadorDeInvestimentos.RealizarInvestimento(conta, arrojado);

Console.ReadKey();