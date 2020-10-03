using System;
using System.Collections.Generic;
using System.Text;

namespace POO_OperacionesHerencia
{
    public abstract class Operaciones
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }

        public abstract decimal Calcular();
    }
}
