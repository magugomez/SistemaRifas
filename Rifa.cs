using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPConstruccion
{
    internal class Rifa
    {
        private string nombre;
        private string apellido;
        private int numeroRifa;

        public Rifa() { }

        public Rifa(string nombre, string apellido, int numeroRifa): this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.numeroRifa = numeroRifa;
        }
    }
}
