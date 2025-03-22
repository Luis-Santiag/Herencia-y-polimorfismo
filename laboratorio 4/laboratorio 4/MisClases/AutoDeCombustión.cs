    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


namespace laboratorio_4.MisClases
{
    internal class AutoDeCombustión : vehiculo
    {
        
        private int nivelCombustible; 
        private bool encendido; 
        private int kilometraje; 

        
        public AutoDeCombustión(int anio, string color, string modelo, int combustibleInicial): base(anio, color, modelo)
        {
            this.nivelCombustible = combustibleInicial;
            this.encendido = false;
            this.kilometraje = 0;
        }

        
        public void Encender()
        {
            if (nivelCombustible > 0)
            {
                encendido = true;
                Console.WriteLine("Auto encendido. ¡Listo para rodar!");
            }
            else
            {
                Console.WriteLine("No hay suficiente combustible para encender el auto.");
            }
        }

        public void Apagar()
        {
            encendido = false;
            Console.WriteLine("Auto apagado.");
        }

        public void CargarCombustible(int cantidad)
        {
            nivelCombustible += cantidad;
            Console.WriteLine($"Combustible cargado. Nivel actual: {nivelCombustible} litros.");
        }

        

        public void Acelerar(int velocidadObjetivo)
        {
            if (encendido)
            {
                while (velocidad < velocidadObjetivo && nivelCombustible > 0)
                {
                    velocidad += 20; 
                    nivelCombustible -= 1; 
                    Console.WriteLine("Acelerando... Velocidad actual: " + velocidad + " km/h | Combustible restante: " + nivelCombustible);
                    System.Threading.Thread.Sleep(1000);
                }

                if (nivelCombustible <= 0)
                {
                    Console.WriteLine("¡Combustible agotado! El auto comenzará a frenar.");
                    
                }
                else
                {
                    Console.WriteLine("El auto ha alcanzado la velocidad objetivo de " + velocidadObjetivo + " km/h.");
                }
            }
            else
            {
                Console.WriteLine("El auto está apagado. No se puede acelerar.");
            }
        }

        public override void Frenar()
        {
            if (encendido)
            {
                while (velocidad > 0) 
                {
                    velocidad = Math.Max(0, velocidad - 20);
                    nivelCombustible -= 1; 
                    Console.WriteLine("Frenando... Velocidad actual: " + velocidad + " km/h");
                    System.Threading.Thread.Sleep(1000);
                }

                Console.WriteLine("El auto se ha detenido completamente.");
            }
            else
            {
                Console.WriteLine("El auto está apagado. No se puede frenar.");
            }
        }
    }
}

