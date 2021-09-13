using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstParcial.Entidades
{
    class Usuario
    {
        private string nombre;
        private double contra;

        public Usuario()
        {
        }

        public Usuario(string nombre, double contra)
        {
            this.Nombre = nombre;
            this.Contra = contra;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Contra { get => contra; set => contra = value; }

        public override string ToString()
        {
            return "su nombre de usuario es: " + nombre + " su clave es: " + contra ;
        }
    }
}
