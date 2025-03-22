using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_4.MisClases
{
 
        internal class Camión : vehiculo
        {
           
            private int capacidadCarga; 
            private int cargaActual; 
            private bool remolqueAcoplado;
            private bool encendido;


        public Camión(int anio, string color, string modelo, int capacidadCarga)
                : base(anio, color, modelo)
            {
                this.capacidadCarga = capacidadCarga;
                this.cargaActual = 0;
                this.remolqueAcoplado = false;
            }
        public void Encender()
        {
            if (!encendido)
            {
                encendido = true;
                Console.WriteLine("Camión encendido. ¡Listo para rodar!");
            }
            else
            {
                Console.WriteLine("El camión ya está encendido.");
            }
        }

        // Método para apagar el camión
        public void Apagar()
        {
            if (encendido)
            {
                encendido = false;
                Console.WriteLine("Camión apagado.");
            }
            else
            {
                Console.WriteLine("El camión ya está apagado.");
            }
        }

        public void AcoplarRemolque()
            {
                remolqueAcoplado = true;
                Console.WriteLine("Remolque acoplado.");
            }

            public void DesacoplarRemolque()
            {
                remolqueAcoplado = false;
                Console.WriteLine("Remolque desacoplado.");
            }

            public void CargarMercancia(int peso)
            {
                if (cargaActual + peso <= capacidadCarga)
                {
                    cargaActual += peso;
                    Console.WriteLine($"Mercancía cargada. Carga actual: {cargaActual} kg.");
                }
                else
                {
                    Console.WriteLine("No se puede cargar, excede la capacidad máxima.");
                }
            }


        public override void Acelerar(int VelObjetiva)
        {


            while (velocidad < VelObjetiva)
            {
                if (remolqueAcoplado)
                {
                    velocidad += 10;
                }
                else
                {
                    velocidad += 20;
                }
                Console.WriteLine("Acelerando... Velocidad actual: " + velocidad + " km/h");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("El vehículo ha alcanzado la velocidad objetivo de " + VelObjetiva + " km/h.");
        }


        public override void Frenar()
            {
                if (remolqueAcoplado)
                {
                    while (velocidad > 0) 
                    {
                        velocidad = Math.Max(0, velocidad - 25); 
                        Console.WriteLine("Frenando con remolque... Velocidad actual: " + velocidad + " km/h");
                        System.Threading.Thread.Sleep(1000); 
                    }
                    Console.WriteLine("El camión se ha detenido completamente.");
                }
                else
                {
                    while (velocidad > 0) 
                    {
                        velocidad = Math.Max(0, velocidad - 20); 
                        Console.WriteLine("Frenando... Velocidad actual: " + velocidad + " km/h");
                        System.Threading.Thread.Sleep(1000); 
                    }
                    Console.WriteLine("El camión se ha detenido completamente.");
                }
            }
        }
    }


