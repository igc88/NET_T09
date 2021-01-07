using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T09 {
    class Alumno {
        
        private string Nombre { get; set; }

        private int Edad { get; set; }

        public Alumno(string nombre, int edad) {
            Nombre = nombre;
            Edad = edad;
        }

        public void mostrarInfo() {
            Console.WriteLine("Me llamo {0} y tengo {1} años.", Nombre, Edad);
        }

        public void mayorEdad() {
            if (Edad > 18) {
                Console.WriteLine("Soy mayor de edad.");
            } else {
                Console.WriteLine("Soy menor de edad.");
            }
        }
    }
}
