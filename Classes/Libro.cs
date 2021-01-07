using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T09 {
    class Libro {
        private string autor { get; set; }
        private string titulo { get; set; }
        private string ubicacion { get; set; }

        public void Main() {
            Libro ESDLA = new Libro();
            ESDLA.autor = "J.R.R. Tolkien";
            ESDLA.titulo = "El Señor de los Anillos";
            ESDLA.ubicacion = "Mordor";

            Console.WriteLine("Autor: {0}", ESDLA.autor);
            Console.WriteLine("Título: {0}", ESDLA.titulo);
            Console.WriteLine("Ubicación: {0}", ESDLA.ubicacion);
        }
    }
}
