using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBanco1._3
{
    internal class Clientes
    {
        public int Id_Cliente { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Dni { get; set; }

        public Clientes()
        {
            Id_Cliente = 0;
            Nombre = "";
            Apellido = "";
            Dni = 0;
        }

        public Clientes(int Id_Cliente, string Nombre, string Apellido, int Dni)
        {
            this.Id_Cliente = Id_Cliente;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Dni = Dni;
        }

        public override string ToString()
        {
            return Nombre + '-' + Apellido;
        }
    }
}
