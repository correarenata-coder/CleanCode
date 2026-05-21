using System;
using System.Collections.Generic;
using System.Text;

namespace ProjCleanCode_Ajustado03.Interface
{
    public interface ICalculadoraDescontoPorFidelidade
    {
        decimal CalcularDesconto(decimal precoDoProduto, int tempoDaContaEmAnos);
    }
}
