using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBanco1._3
{
    internal class TipoCuenta
    {
        public int Id_tipo_cuenta { get; set; }

        public string NombreCuenta { get; set; }

        public TipoCuenta()
        {
            Id_tipo_cuenta = 0;
            NombreCuenta = "";
        }

        public TipoCuenta(int Id_tipo_cuenta, string NombreCuenta)
        {
            this.Id_tipo_cuenta = Id_tipo_cuenta;
            this.NombreCuenta = NombreCuenta;
        }

        public override string ToString()
        {
            return NombreCuenta;
        }
    }
}
