using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaSMN10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.nombre = "Merary ";
            usuario.direccion = "San Miguel, El salvador";
            usuario.correoElec = "Meraryaraujo@gmail.com";
            usuario.codUsuario = 12345;

            Cliente cliente = new Cliente();

            cliente.nombre = "Nathaly ";
            cliente.direccion = "San Miguel, El salvador";
            cliente.correoElec = "Meraryaraujo@gmail.com";
            cliente.Num = 7895302;
         
        }
    }
}
