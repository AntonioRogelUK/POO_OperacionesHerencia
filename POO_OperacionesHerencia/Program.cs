using System;

namespace POO_OperacionesHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma suma = new Suma();
            suma.Valor1 = 10;
            suma.Valor2 = 5;
            
            Resta resta = new Resta();
            resta.Valor1 = 10;
            resta.Valor2 = 5;

            Multiplicacion multiplicacion = new Multiplicacion();
            multiplicacion.Valor1 = 10;
            multiplicacion.Valor2 = 5;

            Division division = new Division();
            division.Valor1 = 10;
            division.Valor2 = 5;

            Imprime(suma);
            Imprime(resta);
            Imprime(multiplicacion);
            Imprime(division);
        }

        static void Imprime(Operaciones operacion) 
        {
            string miOperacion = string.Empty;

            if(operacion is Suma) { miOperacion = "suma"; }
            if(operacion is Resta) { miOperacion = "resta"; }
            if(operacion is Multiplicacion) { miOperacion = "multiplicacion"; }
            if(operacion is Division) { miOperacion = "división"; }

            Console.WriteLine($"La {miOperacion} de {operacion.Valor1} y {operacion.Valor2} es igual a {operacion.Calcular()}");
        }
    }
}
