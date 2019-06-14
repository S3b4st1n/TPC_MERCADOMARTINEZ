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
    public partial class FormularioAcesso : Form
    {
        public FormularioAcesso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool open = false;
            if (textBox1.Text=="demo" && textBox2.Text=="demo")
            {
                frmVenta grilla = new frmVenta();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(frmVenta))
                    {
                        open = true;
                        MessageBox.Show("El formulario ya esta abierto");
                        break;
                    }
                }
                if (!open)
                {
                    grilla.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos");
            }

        }

    }
}
