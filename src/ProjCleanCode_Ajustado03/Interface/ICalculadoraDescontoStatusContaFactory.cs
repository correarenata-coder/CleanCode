using ProjCleanCode_Ajustado03;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjCleanCode_Ajustado03.Interface
{
    public interface ICalculadoraDescontoStatusContaFactory
    {
        ICalculadoraDesconto GetCalculoDescontoStatusConta(StatusDaConta statusDaConta);
    }
}
