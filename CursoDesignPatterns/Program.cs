using CursoDesignPatterns;

//IImposto iss = new ISS();
//IImposto icms = new ICMS();
//IImposto ihit = new IHIT();

Orcamento orcamento = new Orcamento(500);
orcamento.AdicionarItem(new("lapis", 500));
orcamento.AdicionarItem(new("LApist", 500));


orcamento.AplicaDescontoExtra();

orcamento.Aprova();
orcamento.AplicaDescontoExtra();

Console.WriteLine(orcamento.Valor);
//CalculadorImposto calculador = new CalculadorImposto();

//calculador.RealizarCalculo(orcamento, ihit);
////calculador.RealizarCalculo(orcamento, iccc);

//CalculadorDeDescontos calculadorDeDescontos = new CalculadorDeDescontos();

//double desconto = calculadorDeDescontos.Calcula(orcamento);
//Console.WriteLine(desconto);


//Conta conta = new Conta("Ezequiel", "Bradico", 99, "Rua Marj Koir", "16 991458499", "ezequiel.lima.bre@gtml.com","25695-5", "256", DateTime.Now.AddMonths(5));
//Conta conta2 = new Conta("Gustavo", "Kasr", 50000000, "Rua Tjok Louir", "16 915253621", "gustavo.bre@gtml.com","12385-9", "3629", DateTime.Now.AddDays(3));
//Conta conta3 = new Conta("Ketlen", "Kasr", 100, "Rua Tjok Louir", "16 915253621", "gustavo.bre@gtml.com","12385-9", "3629", DateTime.Now.AddMonths(-1).AddDays(15));
//Conta conta4 = new Conta("Gaspar", "Kasr", 100, "Rua Tjok Louir", "16 915253621", "gustavo.bre@gtml.com","12385-9", "3629", DateTime.Now.AddMonths(9));

//IList<Conta> contas = new List<Conta>();
//contas.Add(conta);
//contas.Add(conta2);
//contas.Add(conta3);
//contas.Add(conta4);

//FIltro filtro = new FiltrarContaMenorQueCemReais(new FiltrarContaMaiorQueQuinhentosReais(new FiltrarContaDataAberturaMesCorrente()));


//IList<Conta> contasFiltradas = filtro.Filtrar(contas);

//foreach (var item in contasFiltradas)
//{
//    Console.WriteLine(item.Titular);
//}

//TemplateRelatorio relatorioComplexo = new RelatorioSimples();
//Console.WriteLine(relatorioComplexo.Imprimir(contas)); 


//IImposto impostos = new ImportoMuitoAlto(new IKCV());

//Orcamento orcamento = new Orcamento(500);

//double valor = impostos.Calcula(orcamento);

//Console.WriteLine(valor);



Console.ReadKey();