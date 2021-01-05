using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T09 {
    class Persona {
        private string Nombre { get; set; }

        public void SetNombre(string nombre) {
            this.Nombre = nombre;
        }

        public void Saludar() {
            Console.WriteLine("Hola soy {0}", this.Nombre);
        }


    }
}
