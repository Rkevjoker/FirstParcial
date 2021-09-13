using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstParcial.Entidades
{
    class Ventas
    {
        private double identificador_producto;
        private string nombre_producto;
        private string descripcion;
        private double precio;
        private int cantidad;

        public Ventas()
        {
        }

        public Ventas(double identificador_producto, string nombre_producto, string descripcion, double precio, int cantidad)
        {
            this.Identificador_producto = identificador_producto;
            this.Nombre_producto = nombre_producto;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Cantidad = cantidad;
        }

        public double Identificador_producto { get => identificador_producto; set => identificador_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public override String ToString()
        {
            return "el id de su producto es " + Identificador_producto +
                "\n el nombre de su producto es " + Nombre_producto +
                "\n la descripcion de su producto es" + Descripcion +
                "\n el precio del prudcto es" + Precio +
                "\n la cantidad de producto es " + Cantidad;
        }
    }
}
