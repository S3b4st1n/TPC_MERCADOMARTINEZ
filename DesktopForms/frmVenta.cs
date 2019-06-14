using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace WinForm
{
    public partial class frmVenta : Form
    {
        //esto es un atributo privado propio de esta ventana.
        private BindingList<Persona> listPersonas;
        private bool flagModificacion=false;
        //Este es el constructor de esta ventana. Vino por default.
        public frmVenta()
        {
            
            InitializeComponent();
            
        }

        private void frmListPersona_Load(object sender, EventArgs e)
        {
            //carga manual de colores uno por uno.
            cboColor.Items.Add("Azul");
            cboColor.Items.Add("Amarillo");
            cboColor.Items.Add("Rojo");
            cboColor.Items.Add("Violeta");
            cboColor.Items.Add("Celeste");
            cboColor.Items.Add("Blanco");
            cboColor.Items.Add("Negro");
            cboColor.Items.Add("Verde");
            cboColor.Items.Add("Naranja");
            cboColor.Items.Add("Gris");
            // Creo BindingList
            listPersonas = new BindingList<Persona>();
            // asigno datasource
            dgvPersonas.DataSource = listPersonas;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
  
        }

        // Retorna Edad recibe datetime
        public int Edad(DateTime FechaNacimiento)
        {
                DateTime now = DateTime.Today;
                int edad = DateTime.Today.Year - FechaNacimiento.Year;

                if (DateTime.Today < FechaNacimiento.AddYears(edad))
                    return --edad;
                else
                    return edad;
        }


        // limpio Formulario
        private void Clean_Form()
        {
            grpSexo.Text = "Sexo:   -";
            dtFechaNacimiento.Value = DateTime.Now;
            cboColor.Text = "";
            lblEdad.Text = "Edad: ";
            // Nombre y Apllido false    
            txtNombre.Text = "";
            txtApellido.Text = "";


            // Raddio Button false
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            rbOtro.Checked = false;


            // CheckBox False
            chkFolklore.Checked = false;
            chkMetal.Checked = false;
            chkPop.Checked = false;
            chkRock.Checked = false;
            chkPop.Checked = false;
            chkRegae.Checked = false;
        }


        // seteo en los checkBox los estilos musicales deben estar separados por una ,
        private void setEstilo_Musical(string EstilosMusicales)
        {
            string[] estiloList = EstilosMusicales.Split(',');
            foreach(string estilo in estiloList)
            {
                if(estilo== "Folklore")
                {
                    chkFolklore.Checked = true;
                }
                if (estilo == "Rap")
                {
                    chkRap.Checked = true;
                }
                if (estilo == "Rock")
                {
                    chkRock.Checked = true;
                }
                if (estilo == "Pop")
                {
                    chkPop.Checked = true;
                }
                if (estilo == "Metal")
                {
                    chkMetal.Checked = true;
                }
                if (estilo== "Regae")
                {
                    chkRegae.Checked = true;
                }
            }
        }

        // Devuelve un string con los estilos musicales separados por (,)
        private string Estilo_Musical()
        {
            string estilos="";

            if (chkFolklore.Checked == true)
            {
                estilos = estilos + ",Folklore";
            }
            if (chkPop.Checked == true)
            {
                estilos = estilos + ",Pop";
            }
            if (chkRock.Checked == true)
            {
                estilos = estilos + ",Rock";           
            }
            if (chkRap.Checked == true)
            {
                estilos = estilos + ",Rap";
            }
            if(chkRegae.Checked==true)
            {
                estilos = estilos + ",Regae";
            }
            if(chkMetal.Checked==true)
            {
                estilos = estilos + ",Metal";
            }
                return estilos;
        }
         
        // Devuelve un string con el sexo seleccionado
        private string Valido_Sexo()
        {            
            if (rbFemenino.Checked == true) { return "femenino"; }
            // Check Masculino
            if (rbMasculino.Checked == true) { return "masculino"; }
            // Check otro
            if (rbOtro.Checked == true) { return "otro"; }

            return null;
        }

        // Valido que no existan Valores sin cargar
        private bool DatosErroneos()
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Cargue nombre");
                return false;
            }
            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Cargue Apellido");
                return false;
            }
            if ( cboColor.SelectedIndex < 0)
            {
                MessageBox.Show("Cargue Color");
                return false;
            }
            if (rbFemenino.Checked == false && rbMasculino.Checked == false && rbOtro.Checked == false)
            {
                MessageBox.Show("Cargue Sexo");
                return false;
            }
            if (lblEdad.Text== "Edad: ")
            {
                MessageBox.Show("Cargue Fecha de Nacimiento");
                return false;
            }
  
            if (dtFechaNacimiento.Value > DateTime.Now)
            {        
            MessageBox.Show("No se puede Cargar una fecha a futuro");
            return false;       
            }

            return true;
        }

        // Fundamental Para Actualizar Grilla
        private void refrescarGrilla(){listPersonas.ResetBindings();}

        // Al cambiar fecha cambia lblEdad
        private void dtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            //Muestro la edad segun fecha cargada
            int edad;
            if ((edad = Edad(dtFechaNacimiento.Value)) >= -1)
            {
                lblEdad.Text = "Edad: " + edad;
            }
            else
            {
                lblEdad.Text = "Edad: ";
            }      
            
        }

        private void dgvPersonas_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }


        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
             }


        private void Form_Disable()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            dtFechaNacimiento.Enabled = false;
            grpEstilo.Enabled = false;
            grpSexo.Enabled = false;
            cboColor.Enabled = false;
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;
        }


        private void Form_Enable()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            dtFechaNacimiento.Enabled = true;
            grpEstilo.Enabled = true;
            grpSexo.Enabled = true;
            cboColor.Enabled = true;
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        // Validaciones Para cambio grpSexo
        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
           grpSexo.Text="Sexo: Femenino -";
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
           grpSexo.Text = "Sexo: Masculino -";
        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
           grpSexo.Text = "Sexo: Otro -";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (flagModificacion)
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea Salir de la modificacion?",
                "Salir de Modificacion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    flagModificacion = false;
                    Form_Enable();
                    Clean_Form();
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                }
            }
            else
            {
                Form_Enable();
                Clean_Form();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form_Enable();
            flagModificacion = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }

        private bool Modificar(Persona objPersona)
        {
            return false;
        }

        private bool Eliminar(Persona objPersona)
        {
            return false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea Salir?",
            "Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FormularioAcesso formularioAcesso = new FormularioAcesso();
                formularioAcesso.Show();
                this.Close();
            }
        }
    }
}
