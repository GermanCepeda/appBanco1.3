using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBanco1._3
{
    internal class Cuenta
    {
        public int Id_Cuenta { get; set; }

        public string Cbu { get; set; }

        public int Id_Cliente { get; set; }
        public double Saldo { get; set; }

        public int Id_tipo_cuenta { get; set; }
        
        public DateTime UltimoMovimiento { get; set; }

        public Cuenta()
        {
            Id_Cuenta = 0;
            Cbu = "";
            Id_Cliente = 0;
            Saldo = 0;
            Id_tipo_cuenta = 0;
            UltimoMovimiento = DateTime.Now;
        }

        public Cuenta( int Id_Cuenta, string Cbu, int Id_Cliente, double Saldo, int Id_tipo_cuenta, DateTime UltimoMovimiento)
        {
            this.Id_Cuenta = Id_Cuenta;
            this.Cbu = Cbu;
            this.Id_Cliente = Id_Cliente;
            this.Saldo = Saldo;
            this.Id_tipo_cuenta = Id_tipo_cuenta;
            this.UltimoMovimiento = UltimoMovimiento;
        }

        public override string ToString()
        {
            return Cbu +"-"+ Saldo +"-"+ Id_tipo_cuenta +"-"+ UltimoMovimiento.ToString();
        }
    }
}
