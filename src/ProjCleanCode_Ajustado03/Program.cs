using Microsoft.Extensions.DependencyInjection;
using ProjCleanCode_Ajustado03;
using ProjCleanCode_Ajustado03.Interface;


var serviceProvier = new ServiceCollection()
    .AddScoped<ICalculadoraDescontoStatusContaFactory, CalculadoraDescontoStatusFactory>()
    .AddScoped<ICalculadoraDescontoPorFidelidade, CalculadoraDescontoPorFidelidade>()
    .AddScoped<CalculadoraDeDesconto>()
    .BuildServiceProvider();

var calculadoraDeDesconto = serviceProvier.GetService<CalculadoraDeDesconto>()
    ?? throw new InvalidOperationException("Não foi possível obter a calculadora de desconto.");

Console.WriteLine("=== Calculadora de Desconto ===");

// Entrada de dados
Console.Write("Informe o preço do produto: ");
decimal precoDoProduto = Convert.ToDecimal(Console.ReadLine());

Console.Write("Informe o status da conta (1-Comum, 2-Premium , 3-VIP): ");
int statusConta = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o tempo da conta em anos: ");
int tempoDaContaEmAnos = Convert.ToInt32(Console.ReadLine());




decimal novoPreco = calculadoraDeDesconto.AplicarDesconto(
    precoDoProduto,
    StatusDaConta.ClientePadrao,
    tempoDaContaEmAnos);

// Resultado
Console.WriteLine();
Console.WriteLine("Novo preço ClientePadrao: " + novoPreco);

 novoPreco = calculadoraDeDesconto.AplicarDesconto(
    precoDoProduto,
    StatusDaConta.ClienteEspecial,
    tempoDaContaEmAnos);

// Resultado
Console.WriteLine();
Console.WriteLine("Novo preço ClienteEspecial: " + novoPreco);

 novoPreco = calculadoraDeDesconto.AplicarDesconto(
    precoDoProduto,
    StatusDaConta.ClienteOuro,
    tempoDaContaEmAnos);

// Resultado
Console.WriteLine();
Console.WriteLine("Novo preço ClientePadrao: " + novoPreco);

 novoPreco = calculadoraDeDesconto.AplicarDesconto(
    precoDoProduto,
    StatusDaConta.ClienteVIP,
    tempoDaContaEmAnos);

// Resultado
Console.WriteLine();
Console.WriteLine("Novo preço ClientePadrao: " + novoPreco);

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();