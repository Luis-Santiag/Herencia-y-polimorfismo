using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_4.MisClases
{
    
        internal class Motocicleta : vehiculo
        {
            
            private bool cascoColocado; 
            private int nivelAceite; 
            private bool enMovimiento; 
            private bool encendido;


        public Motocicleta(int anio, string color, string modelo, int aceiteInicial)
                : base(anio, color, modelo)
            {
                this.cascoColocado = false;
                this.nivelAceite = aceiteInicial;
                this.enMovimiento = false;
            }

        public void Encender()
        {
            if (!encendido)
            {
                encendido = true;
                Console.WriteLine("Moto encendida. ¡Listo para rodar!");
            }
            else
            {
                Console.WriteLine("La moto ya está encendida.");
            }
        }

        // Método para apagar la moto
        public void Apagar()
        {
            if (encendido)
            {
                encendido = false;
                Console.WriteLine("Moto apagada.");
            }
            else
            {
                Console.WriteLine("La moto ya está apagada.");
            }
        }

        public void ColocarCasco()
            {
                cascoColocado = true;
                Console.WriteLine("Casco colocado. ¡Listo para conducir!");
            }

            public void QuitarCasco()
            {
                cascoColocado = false;
                Console.WriteLine("Casco quitado.");
            }

            public void VerificarAceite()
            {
                Console.WriteLine($"Nivel de aceite: {nivelAceite}%");
            }

            
            public override void Acelerar(int Objetivo)
            {
            if (cascoColocado)
            {
                while (velocidad < Objetivo)
                {
                    velocidad += 25; 
                    enMovimiento = true;
                    Console.WriteLine("Acelerando... Velocidad actual: " + velocidad + " km/h");
                    System.Threading.Thread.Sleep(1000); 
                }

                Console.WriteLine("La motocicleta ha alcanzado la velocidad objetivo de " + Objetivo + " km/h.");
            }
            else
            {
                Console.WriteLine("Coloca el casco antes de acelerar.");
            }
        }
            

            
            public override void Frenar()
            {
                if (enMovimiento)
                {
                    while (velocidad > 0)
                    {
                        velocidad = Math.Max(0, velocidad - 15);
                        Console.WriteLine("Frenando... Velocidad actual: " + velocidad + " km/h");
                        System.Threading.Thread.Sleep(1000); 
                    }
                    Console.WriteLine("La motocicleta se ha detenido completamente.");
                }
                else
                {
                    Console.WriteLine("La motocicleta no está en movimiento. No se puede frenar.");
                }
            }
        }
    }

