using System;
using System.Collections.Generic;
using System.Text;

namespace ProjCleanCode_Ajustado01.Exemplo
{
    public class CalculadoraDeDesconto
    {
        public decimal CalcularDesconto(decimal precoDoProduto, int statusDaConta, int tempoDaContaEmAnos)
        {
            decimal precoDepoisDoDesconto = 0;
            decimal pencentualDoDescontoPorFidelidade = (tempoDaContaEmAnos > 5) ? (decimal)5 / 100 : (decimal)tempoDaContaEmAnos / 100;

            if (statusDaConta == 1) { 
                precoDepoisDoDesconto = precoDoProduto;
            }
            else if (statusDaConta == 2)
            {
                precoDepoisDoDesconto = (precoDoProduto - (0.1m * precoDoProduto)) 
                                        - pencentualDoDescontoPorFidelidade 
                                        * (precoDoProduto - (0.1m * precoDoProduto));
            }
            else if (statusDaConta == 3)
            {
                precoDepoisDoDesconto = (0.7m * precoDoProduto)
                                        - pencentualDoDescontoPorFidelidade * (0.7m * precoDoProduto);
            }
            else if (statusDaConta == 4)
            {
                precoDepoisDoDesconto = (precoDoProduto - (0.5m * precoDoProduto)) 
                                        - pencentualDoDescontoPorFidelidade 
                                        * (precoDoProduto - (0.5m * precoDoProduto));
            }
            return precoDepoisDoDesconto;
        }
    }
}
