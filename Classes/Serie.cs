using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T09 {
    class Serie {

        private string Titulo { get; set; } = string.Empty;
        private int NumTemporadas { get; set; } = 3;
        private bool Entregado { get; set; } = false;
        private Generos Genero { get; set; } = Generos.Drama;
        private string Creador { get; set; } = string.Empty;

        public enum Generos {
            Thriller, SCI_FI, Drama, Comedia, Terror, Animación
        }

        public Serie() {}
        public Serie(string titulo, string creador) {
            this.Titulo = titulo;
            this.Creador = creador;
        }
        public Serie(string titulo, int numTemporadas, Generos genero, string creador) {
            this.Titulo = titulo;
            this.NumTemporadas = numTemporadas;
            this.Genero = genero;
            this.Creador = creador;
        }
        public void MostrarDatos() {
            Console.WriteLine("Titulo: {0}", this.Titulo);
            Console.WriteLine("Número de temporadas: {0}", this.NumTemporadas);
            Console.WriteLine("Entregado: {0}", this.Entregado ? "Sí" : "No");
            Console.WriteLine("Género: {0}", this.Genero);
            Console.WriteLine("Creador: {0}", this.Creador);
        }
    }
}
