using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T09 {
    class Password {
        private int Longitud { get; set; } = 8;
        private string Contrasena { get; set; }
        public Password () { }
        public Password(int longitud) {
            string passwd = string.Empty;
            string[] letras = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            Random rnd = new Random();

            this.Longitud = longitud;

            for (int i = 0; i < this.Longitud; i++) {
                int LetraAleatoria = rnd.Next(0, 100);
                int NumeroAleatorio = rnd.Next(0, 9);

                if (LetraAleatoria < letras.Length) {
                    passwd += letras[LetraAleatoria];
                } else {
                    passwd += NumeroAleatorio.ToString();
                }
            }

            this.Contrasena = passwd;
        }

        public void Mostrar() {
            Console.WriteLine("Contraseña: {0}", this.Contrasena);
        }
    }
}
