using FirstParcial.Entidades;
using FirstParcial.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
           
            ClsUsuario clsUsuario = new ClsUsuario();

            Console.WriteLine("digite el nombre de usuario");
            string nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Escriba su clave de accesos");
            double contra = Convert.ToDouble(Console.ReadLine());
            Usuario Cons = new Usuario(nombre, contra);
            Console.WriteLine(clsUsuario.Acceso(Cons));

            if (clsUsuario.y == 1)
            {
                int x = 1;
                while ( x== 1)
                {
                    Console.WriteLine("ingrese el id del producto");
                    double identificador_producto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingrese el nombre del producto");
                    string nombre_producto = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("ingrese la descripcion del producto");
                    string descripcion = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("ingrese la precio del producto");
                    double precio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingrese la cantidad del producto");
                    int cantidad = Convert.ToInt32(Console.ReadLine());

                    Ventas vent = new Ventas(identificador_producto, nombre_producto, descripcion, precio, cantidad);

                    ClsVentas cls = new ClsVentas();

                    Ventas ventas = new Ventas();
                    
                    Console.WriteLine(cls.Cobro(vent));

                    Console.WriteLine(usuario.ToString());
                    Console.WriteLine(ventas.ToString());
                    Console.ReadLine();

                }
            }

        }
    }
}
