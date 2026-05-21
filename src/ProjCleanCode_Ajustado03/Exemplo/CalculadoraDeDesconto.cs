using ProjCleanCode_Ajustado03;
using ProjCleanCode_Ajustado03.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjCleanCode_Ajustado03
{
    public class CalculadoraDeDesconto
    {
        private readonly ICalculadoraDescontoStatusContaFactory _calculadoraDescontoStatusContaFactory;
        private readonly ICalculadoraDescontoPorFidelidade _calculadoraDescontoProFidelidade;

        public CalculadoraDeDesconto(ICalculadoraDescontoStatusContaFactory calculadoraDescontoStatusContaFactory, ICalculadoraDescontoPorFidelidade calculadoraDescontoProFidelidade)
        {
            _calculadoraDescontoStatusContaFactory = calculadoraDescontoStatusContaFactory;
            _calculadoraDescontoProFidelidade = calculadoraDescontoProFidelidade;
        }

        public decimal AplicarDesconto(decimal precoDoProduto, StatusDaConta statusDaConta, int tempoDaContaEmAnos)
        {
            var calculadoraDesconto = _calculadoraDescontoStatusContaFactory.GetCalculoDescontoStatusConta(statusDaConta);

            var precoComDescontosStatus = calculadoraDesconto.AplicarDesconto(precoDoProduto);

            var precoFinal = _calculadoraDescontoProFidelidade.CalcularDesconto(precoComDescontosStatus,
                              tempoDaContaEmAnos);

            
            return precoFinal;
        }


        

    }
}
