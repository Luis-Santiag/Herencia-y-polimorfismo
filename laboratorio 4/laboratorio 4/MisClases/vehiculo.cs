using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace laboratorio_4.MisClases
{
    internal class vehiculo
    {
        public string color { get; set; }
        public string modelo { get; }
        public int Year { get; }

        protected int velocidad = 0; 

        public vehiculo(int Anio, string Elcolor, string Elmodelo)
        {
            this.color = Elcolor;
            this.modelo = Elmodelo;
            this.Year = Anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color :{0}", this.color);
            Console.WriteLine("Modelo :{0}", this.modelo);
            Console.WriteLine("Año :{0}", this.Year);
        }
        public virtual void Acelerar(int incremento)
        {
            velocidad += incremento;
            Console.WriteLine("Acelerando... Velocidad actual: " + velocidad + " km/h");
        }

     
        public virtual void Frenar()
        {
            velocidad = Math.Max(0, velocidad - 10);
            Console.WriteLine("Frenando... Velocidad actual: " + velocidad + " km/h");
        }
    }
}


