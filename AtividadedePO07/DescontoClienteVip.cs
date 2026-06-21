using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadedePO08
{
    public class DescontoClienteVip : IDescontos
    {
        public decimal Calcular(decimal valor)
        {
            return valor - (valor * 0.10m);
        }
    }
}
