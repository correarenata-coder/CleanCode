using ProjCleanCode_Ajustado03.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjCleanCode_Ajustado03
{
    public class DescontoClienteOuro : ICalculadoraDesconto
    {
        public decimal AplicarDesconto(decimal preco)
        {
            return preco - (Constantes.DESCONTO_CLIENTE_OURO* preco);
        }
    }
}
