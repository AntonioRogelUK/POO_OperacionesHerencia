﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POO_OperacionesHerencia
{
    public class Division : Operaciones
    {
        public override decimal Calcular()
        {
            return Valor1 / Valor2;
        }
    }
}
