using ProjCleanCode_Ajustado02;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjCleanCode_Ajustado02
{
    public class CalculadoraDeDesconto
    {
        public decimal CalcularDesconto(decimal precoDoProduto, StatusDaConta statusDaConta, int tempoDaContaEmAnos)
        {
            decimal precoDepoisDoDesconto = 0;
            decimal pencentualDoDescontoPorFidelidade = (tempoDaContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ? 
                (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 : (decimal)tempoDaContaEmAnos / 100;

            switch (statusDaConta)
            {   
                case StatusDaConta.ClientePadrao:
                    precoDepoisDoDesconto = precoDoProduto;
                    break;
                case StatusDaConta.ClienteEspecial:
                    precoDepoisDoDesconto = CalcularPrecoDeposDoDesconto(precoDoProduto, Constantes.DESCONTO_CLIENTE_ESPECIAL, pencentualDoDescontoPorFidelidade);
                    break;
                case StatusDaConta.ClienteOuro:
                    precoDepoisDoDesconto = CalcularPrecoDeposDoDesconto(precoDoProduto, Constantes.DESCONTO_CLIENTE_OURO, pencentualDoDescontoPorFidelidade);
                    break;
                case StatusDaConta.ClienteVIP:
                    precoDepoisDoDesconto = CalcularPrecoDeposDoDesconto(precoDoProduto, Constantes.DESCONTO_CLIENTE_VIP, pencentualDoDescontoPorFidelidade);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return precoDepoisDoDesconto;
        }


        private decimal CalcularPrecoDeposDoDesconto(decimal precoDoProduto, decimal percentualDesconto,
            decimal pencentualDoDescontoPorFidelidade)
        {
            return (precoDoProduto - (percentualDesconto * precoDoProduto))
                   - pencentualDoDescontoPorFidelidade
                   * (precoDoProduto - (percentualDesconto * precoDoProduto));
        }

    }
}
