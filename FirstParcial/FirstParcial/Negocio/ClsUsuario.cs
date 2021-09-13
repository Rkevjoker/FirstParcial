using FirstParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstParcial.Negocio
{
    class ClsUsuario
    {
        string user = "Ronald";
        Double clave = 123;
        public int y = 1;

        Usuario Cons = new Usuario();


        public string Acceso(Usuario Cons)
        {
            if (Cons.Nombre == user && Cons.Contra == clave)

            {
                y = 1;
                return "As iniciado secion Correctamente";
            }
            else
                y = 2;
            return "usuario o contraseña incorrecta";
        }
    }
}
