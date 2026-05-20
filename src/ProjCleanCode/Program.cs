using ProjCleanCode;
using ProjCleanCode.Exemplo;

Console.WriteLine("=== Calculadora de Desconto ===");

// Entrada de dados
Console.Write("Informe o preço do produto: ");
decimal precoDoProduto = Convert.ToDecimal(Console.ReadLine());

Console.Write("Informe o status da conta (1-Comum, 2-Premium , 3-VIP): ");
int statusConta = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o tempo da conta em anos: ");
int tempoDaContaEmAnos = Convert.ToInt32(Console.ReadLine());

// Instância da calculadora
var calculadora = new calc1();

// Cálculo do desconto
var novoPreco = calculadora.calculos(
    precoDoProduto,
    statusConta,
    tempoDaContaEmAnos);

// Resultado
Console.WriteLine();
Console.WriteLine("Novo preço: " + novoPreco);

Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();