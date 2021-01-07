using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T09 {
    class Coche {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private int Cilindrada { get; set; }
        private double Potencia { get; set; }
        public void Main() {
            Coche automovil = new Coche();
            automovil.Marca = "Ford";
            automovil.Modelo = "GT";
            automovil.Cilindrada = 3500;
            automovil.Potencia = 647;

            Console.WriteLine("{0} {1} - {2}cc {3} CV", automovil.Marca, automovil.Modelo, automovil.Cilindrada, automovil.Potencia);
        }
    }
}
