using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSMN10
{
    class Cliente : Persona
    {
        public int Num { get; set; }
        public int fechaAlta { get; set; }



        public int VerFEchaAlta()

        {
            return Num + fechaAlta;
        }
       

            


            //metodo sobreescrito 
            public override string borrar()
        {
            return "No se encontro el registro "; //base.borrar();
        }


    }
    }

