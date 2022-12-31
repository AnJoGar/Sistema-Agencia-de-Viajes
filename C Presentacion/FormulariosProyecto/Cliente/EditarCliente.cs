using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Presentacion.FormulariosProyecto.Cliente
{
    public partial class EditarCliente : Form
    {
        private Form FormularioActivo = null;
        private Panel LeftBorderBtn;
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnConsul_Click(object sender, EventArgs e)
        {
             ConsultarCliente consultarCl = new ConsultarCliente();
            consultarCl.ShowDialog();
        }

    

    }
}
