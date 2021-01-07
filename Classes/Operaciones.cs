using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_T09 {
    class Operaciones {
        private int op1 { get; set; }
        private int op2 { get; set; }

        public Operaciones(int op1, int op2) {
            this.op1 = op1;
            this.op2 = op2;
        }

        public void Suma() {
            Console.WriteLine("{0} + {1} = {2}", this.op1, this.op2, this.op1+this.op2);
        }

        public void Resta() {
            Console.WriteLine("{0} - {1} = {2}", this.op1, this.op2, this.op1 - this.op2);
        }

        public void Multiplicacion() {
            Console.WriteLine("{0} * {1} = {2}", this.op1, this.op2, this.op1 * this.op2);
        }

        public void Division() {
            Console.WriteLine("{0} / {1} = {2}", this.op1, this.op2, this.op1 / this.op2);
        }
    }
}
