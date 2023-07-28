using CursoDesignPatterns;

//IImposto iss = new ISS();
//IImposto icms = new ICMS();
//IImposto ihit = new IHIT();

//Orcamento orcamento = new Orcamento(500);
//orcamento.AdicionarItem(new("lapis", 500));
//orcamento.AdicionarItem(new("LApist", 500));

//CalculadorImposto calculador = new CalculadorImposto();

//calculador.RealizarCalculo(orcamento, ihit);
////calculador.RealizarCalculo(orcamento, iccc);

//CalculadorDeDescontos calculadorDeDescontos = new CalculadorDeDescontos();

//double desconto = calculadorDeDescontos.Calcula(orcamento);
//Console.WriteLine(desconto);


Conta conta = new Conta("Ezequiel", "Bradico", 2560.0, "Rua Marj Koir", "16 991458499", "ezequiel.lima.bre@gtml.com","25695-5", "256");
Conta conta2 = new Conta("Gustavo", "Kasr", 2560.0, "Rua Tjok Louir", "16 915253621", "gustavo.bre@gtml.com","12385-9", "3629");

IList<Conta> contas = new List<Conta>();
contas.Add(conta);
//contas.Add(conta2);

TemplateRelatorio relatorioComplexo = new RelatorioSimples();
Console.WriteLine(relatorioComplexo.Imprimir(contas)); 

Console.ReadKey();