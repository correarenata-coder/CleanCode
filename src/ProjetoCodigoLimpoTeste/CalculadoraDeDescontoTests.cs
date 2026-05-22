using Microsoft.Extensions.DependencyInjection;
using ProjCleanCode_Ajustado03;
using ProjCleanCode_Ajustado03.Interface;

namespace ProjetoCodigoLimpoTeste
{
    public class CalculadoraDeDescontoTests
    {
        private readonly CalculadoraDeDesconto _calculadoraDeDesconto;

        public  CalculadoraDeDescontoTests()
        {
             var serviceCollection= new ServiceCollection();
             serviceCollection.AddTransient<ICalculadoraDescontoStatusContaFactory,
                  CalculadoraDescontoStatusFactory>();

            serviceCollection.AddTransient<ICalculadoraDescontoPorFidelidade,
                  CalculadoraDescontoPorFidelidade>();

            serviceCollection.AddTransient<CalculadoraDeDesconto>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            _calculadoraDeDesconto = serviceProvider.GetService<CalculadoraDeDesconto>()
                ?? throw new InvalidOperationException("Não foi possível resolver a dependência de CalculadoraDeDesconto");

        }
        [Theory]
        [InlineData(100, StatusDaConta.ClientePadrao, 0, 100)]
        [InlineData(100, StatusDaConta.ClienteEspecial, 2, 88.20)]
        [InlineData(100, StatusDaConta.ClienteOuro, 3, 77)]
        [InlineData(100, StatusDaConta.ClienteVIP, 5, 47.50)]
        public void CalcularDesconto_ValidInputs_ReturnsExpectedResult(decimal precoProduto,
                                                             StatusDaConta statusDaConta,
                                                             int tempoDeContaEmAnos,
                                                             decimal resultadoEsperado)
        {
            // Act - executa o teste
            var resultado = _calculadoraDeDesconto.AplicarDesconto(precoProduto, statusDaConta, tempoDeContaEmAnos);

            // Assert - verifica o resultado
            // precisao de duas casas decimais
            Assert.Equal(resultadoEsperado, resultado, 2);
        }

        [Fact]
        public void CalcularDesconto_InvalidStatusDaConta_ThrowsArgumentOutOfRangeException()
        {
            // Arrange - Preparação do testes
            var precoProduto = 100m;
            var tempoDeContaEmAnos = 1;
            // status invalido
            var statusDaConta = (StatusDaConta)99;

            // Act & Assert - execução e verificação
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                 _calculadoraDeDesconto.AplicarDesconto(precoProduto, statusDaConta, tempoDeContaEmAnos));
        }
    }
}
