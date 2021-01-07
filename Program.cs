using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T09 {
    class Program {
        static void Main(string[] args) {
            //E1
            //Alumno Iago = new Alumno("Iago", 32);
            //Iago.mostrarInfo();
            //Iago.mayorEdad();

            //E2
            //Empleado Iago = new Empleado("Iago", 3500.25);
            //Iago.mostrarInfo();
            //Iago.pagarImpuestos();

            //E3
            //Operaciones o = new Operaciones(5, 8);
            //o.Suma();
            //o.Resta();
            //o.Multiplicacion();
            //o.Division();

            //E4
            //PruebaPersona prueba = new PruebaPersona();
            //prueba.Main();

            //E5
            //Libro Libro1 = new Libro();
            //Libro1.Main();

            //E6
            //Coche c1 = new Coche();
            //c1.Main();

            //E7
            //Persona p1 = new Persona();
            //Persona p2 = new Persona("Araceli", 35, "Mujer");
            //Persona p3 = new Persona("Iago", 32, "Hombre", "39924428Q", 1.74, 65);

            //p1.MostrarDatos();
            //p2.MostrarDatos();
            //p3.MostrarDatos();

            //E8
            //Password p1 = new Password(6);
            //p1.Mostrar();

            //E9
            //Electrodomestico e1 = new Electrodomestico();
            //Electrodomestico e2 = new Electrodomestico(1200, 100);
            //Electrodomestico e3 = new Electrodomestico(1200, Electrodomestico.Colores.Gris, Electrodomestico.Consumos.D, 1500);
            //e1.MostrarDatos();
            //e2.MostrarDatos();
            //e3.MostrarDatos();

            //E10
            Serie serie = new Serie();
            Serie serie2 = new Serie("Lost", "JJ Abrahms");
            Serie serie3 = new Serie("La casa de papel", 5, Serie.Generos.Thriller, "Alex Pina");

            serie.MostrarDatos();
            serie2.MostrarDatos();
            serie3.MostrarDatos();

            Console.ReadKey();
        }
    }
}
