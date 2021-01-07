using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T09 {
    class Persona {
        private const string DefaultSexo = "Hombre";
        private string Nombre { get; set; } = "";
        private int Edad { set; get; } = 0;
        private string DNI { set; get; } 
        private string Sexo { set; get; } = DefaultSexo;
        private double Altura { set; get; } = 0;
        private int Peso { set; get; } = 0;

        public void SetNombre(string nombre) {
            this.Nombre = nombre;
        }

        public void Saludar() {
            Console.WriteLine("Hola soy {0}", this.Nombre);
        }

        public Persona() { }

        public Persona(string nombre, int edad, string sexo) {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
        }

        public Persona(string nombre, int edad, string sexo, string dni, double altura, int peso) {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            this.DNI = dni;
            this.Altura = altura;
            this.Peso = peso;
        }

        public void MostrarDatos() {
            Console.WriteLine("Nombre: {0}", this.Nombre);
            Console.WriteLine("Edad: {0}", this.Edad);
            Console.WriteLine("Sexo: {0}", this.Sexo);
            Console.WriteLine("DNI: {0}", this.DNI);
            Console.WriteLine("Altura: {0}", this.Altura);
            Console.WriteLine("Peso: {0}", this.Peso);
        }
    }
}
