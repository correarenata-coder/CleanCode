using ProjCleanCode_Ajustado03.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjCleanCode_Ajustado03
{
    public class CalculadoraDescontoStatusFactory : ICalculadoraDescontoStatusContaFactory
    {
        public ICalculadoraDesconto GetCalculoDescontoStatusConta(StatusDaConta statusDaConta)
        {
            ICalculadoraDesconto calcular;
            switch (statusDaConta)
            {
                case StatusDaConta.ClientePadrao:
                    calcular = new DescontoClientePadrao();
                    break;
                case StatusDaConta.ClienteEspecial:
                    calcular = new DescontoClienteEspecial();
                    break;
                case StatusDaConta.ClienteOuro:
                    calcular = new DescontoClienteOuro();
                    break;
                case StatusDaConta.ClienteVIP:
                    calcular = new DescontoClienteVIP();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return calcular;
        }
    }
}
