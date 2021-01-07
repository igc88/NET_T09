using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T09 {
    class PruebaPersona {
        public void Main() {
            Persona individuo1 = new Persona();
            Persona individuo2 = new Persona();

            individuo1.SetNombre("Iago");
            individuo2.SetNombre("Biel");

            individuo1.Saludar();
            individuo2.Saludar();
        }
    }
}
