using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadedePO08
{
    public class DescontoClienteComum : IDescontos
    {
        public decimal Calcular(decimal valor)
        {
            return valor - (valor * 0.05m);
        }
    }
}
