using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSMN10
{
    class Persona
    {

        //  INTEGRANTES 
        // Merary Julissa Araujo Velasquez 
        //Nathaly Sarai Rodriguez Silva 

        //propiedades 
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string correoElec { get; set; }
       


        //metodos 
        public string crear()
        {

            var mensaj = "";


            if (crea== true)
            {
                mensaj = "Registro Creado!";
            }
            else
            {
                mensaj = "El registro no se ha podido crear ";
            }
            return "Registro exitoso"; 

        }


        public virtual string borrar()
        {

            return "El registro eliminado";
        }
         
            public string borrar(string nombre)
            {
            return "El registro " + nombre +
                " no ha sido encontrado  "; 
            }


        

        public string enviarMensaje()
        {

            var mensaje = "";


            if (autoriza == true)
            {
                mensaje = "Autorizado";
            }
            else
            {
                mensaje = "No esta Autorizado";
            }
            return "Usuario " + mensaje;
        }

        //metodo extra 

        public string datos()
        {
            return "Datos de registro \n " + nombre +","+ direccion + "," + correoElec; 

        }

             public Boolean autoriza { get; set; }
        public Boolean crea { get; set; }
      
    }
    }


