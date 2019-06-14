using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            bool open = false;
            FormularioAcesso formulario = new FormularioAcesso();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(FormularioAcesso))
                {
                    open = true;
                    MessageBox.Show("El formulario ya esta abierto");
                    break;
                }
            }
            if (!open)
            {
                formulario.MdiParent = this;
                formulario.Show();
            }
        }

        private void btnEjemploGrilla_Click(object sender, EventArgs e)
        {
            
        }

    }
}
