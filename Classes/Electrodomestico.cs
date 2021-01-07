using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T09 {
    class Electrodomestico {
        public enum Consumos {
            A, B, C, D, E, F
        }

        public enum Colores {
            Blanco, Negro, Rojo, Azul, Gris
        }

        protected int PrecioBase { get; set; } = 100;
        protected Colores Color { get; set; } = Colores.Blanco;
        protected Consumos ConsumoEnergetico { get; set; } = Consumos.F;
        protected int Peso { get; set; } = 5;
        public Electrodomestico() { }
        public Electrodomestico(int precio, int peso) {
            this.PrecioBase = precio;
            this.Peso = peso;
        }

        public Electrodomestico(int precio, Colores color, Consumos consumo, int peso) {
            this.PrecioBase = precio;
            this.Color = color;
            this.ConsumoEnergetico = consumo;
            this.Peso = peso;
        }

        public void MostrarDatos() {
            Console.WriteLine("Precio: {0} €", this.PrecioBase);
            Console.WriteLine("Color: {0} ", this.Color);
            Console.WriteLine("Consumo: {0} KW", this.ConsumoEnergetico);
            Console.WriteLine("Peso: {0} kg", this.Peso);
        }
    }
}
