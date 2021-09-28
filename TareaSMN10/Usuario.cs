using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSMN10
{
    class Usuario:Persona
    {
        //propiedad codigo de usuario 

        public int codUsuario { get; set; }

        //metodos
        
        public string autorizar()
            {
            {
                var mensaje = "";
                if (nombre == "Usuario") 
                {
                    mensaje  = "Autorizado";
                }
                else
                {
                    mensaje = "No esta Autorizado";
                }
                return "La persona " + nombre + mensaje; 
            }
        }
        public string Creaar()
        {
            return crear();
        }

    }
}
