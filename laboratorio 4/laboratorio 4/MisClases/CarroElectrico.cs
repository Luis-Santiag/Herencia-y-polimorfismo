using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_4.MisClases
{
    internal class CarroElectrico : vehiculo
    {
        private int CargaBateria;
        public CarroElectrico(int Anio, string Elcolor, string Elmodelo) : base(Anio, Elcolor, Elmodelo)
        {
          CargaBateria = 50;
        }
     
        public int NivelBateria() { return CargaBateria; }
        public void cargarBateria()
        {
            CargaBateria++;
        }
    }
}
