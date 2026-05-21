using ProjCleanCode_Ajustado03.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjCleanCode_Ajustado03
{
    public class CalculadoraDescontoPorFidelidade : ICalculadoraDescontoPorFidelidade
    {
        public decimal CalcularDesconto(decimal precoDoProduto, int tempoDaContaEmAnos)
        {
           decimal pencentualDoDescontoPorFidelidade = 
                (tempoDaContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ?
                (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 : 
                (decimal)tempoDaContaEmAnos / 100;
            var precoComDesconto = precoDoProduto - (precoDoProduto * pencentualDoDescontoPorFidelidade * precoDoProduto);

            return precoComDesconto;
        }
    }
}
