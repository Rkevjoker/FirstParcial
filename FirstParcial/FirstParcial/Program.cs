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
            String nombre = Console.ReadLine();
            Double contra = Convert.ToDouble(Console.ReadLine());

            Usuario Cons = new Usuario(nombre, contra);
            ClsUsuario clsUsuario = new ClsUsuario();

            Console.WriteLine("digite el nombre de usuario");
            Cons.Nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Escriba su clave de accesos");
            Cons.Contra = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(clsUsuario.Acceso(Cons));

            Ventas ventas = new Ventas();


        }
    }
}
