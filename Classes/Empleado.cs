using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T09 {
    class Empleado {
        private string Nombre { get; set; }
        private double Sueldo { get; set; }

        public Empleado(string nombre, double sueldo) {
            this.Nombre = nombre;
            this.Sueldo = sueldo;
        }

        public void mostrarInfo() {
            Console.WriteLine("Nombre: {0}  -  Sueldo: {1}", this.Nombre, this.Sueldo);
        }

        public void pagarImpuestos() {
            if (this.Sueldo>3000) {
                Console.WriteLine("Debe pagar impuestos");
            } else {
                Console.WriteLine("No debe pagar impuestos");
            }
        }
    }
}
