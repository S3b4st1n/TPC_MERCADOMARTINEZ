namespace WinForm
{
    partial class frmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblEdad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.chkPop = new System.Windows.Forms.CheckBox();
            this.chkRock = new System.Windows.Forms.CheckBox();
            this.chkMetal = new System.Windows.Forms.CheckBox();
            this.chkRap = new System.Windows.Forms.CheckBox();
            this.chkFolklore = new System.Windows.Forms.CheckBox();
            this.chkRegae = new System.Windows.Forms.CheckBox();
            this.grpEstilo = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.grpSexo.SuspendLayout();
            this.grpEstilo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersonas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPersonas.Location = new System.Drawing.Point(497, 40);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(670, 313);
            this.dgvPersonas.TabIndex = 0;
            this.dgvPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonas_CellContentClick);
            this.dgvPersonas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPersonas_ColumnHeaderMouseClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(65, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(65, 80);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 17);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(31, 350);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(91, 17);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color Favorito:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(140, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(266, 24);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(140, 73);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(266, 24);
            this.txtApellido.TabIndex = 5;
            // 
            // cboColor
            // 
            this.cboColor.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(140, 342);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(266, 25);
            this.cboColor.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(18, 384);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 55);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(267, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(210, 55);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(15, 114);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(107, 17);
            this.lblFechaNacimiento.TabIndex = 11;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaNacimiento.Location = new System.Drawing.Point(140, 107);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(266, 24);
            this.dtFechaNacimiento.TabIndex = 12;
            this.dtFechaNacimiento.ValueChanged += new System.EventHandler(this.dtFechaNacimiento_ValueChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(412, 113);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(41, 17);
            this.lblEdad.TabIndex = 13;
            this.lblEdad.Text = "Edad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 14;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rbOtro);
            this.grpSexo.Controls.Add(this.rbMasculino);
            this.grpSexo.Controls.Add(this.rbFemenino);
            this.grpSexo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSexo.Location = new System.Drawing.Point(18, 150);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(459, 52);
            this.grpSexo.TabIndex = 15;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo:   -";
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOtro.Location = new System.Drawing.Point(327, 18);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(52, 21);
            this.rbOtro.TabIndex = 2;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.rbOtro_CheckedChanged);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(181, 18);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(81, 21);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.Location = new System.Drawing.Point(16, 20);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(80, 21);
            this.rbFemenino.TabIndex = 0;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            this.rbFemenino.CheckedChanged += new System.EventHandler(this.rbFemenino_CheckedChanged);
            // 
            // chkPop
            // 
            this.chkPop.AutoSize = true;
            this.chkPop.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPop.Location = new System.Drawing.Point(181, 60);
            this.chkPop.Name = "chkPop";
            this.chkPop.Size = new System.Drawing.Size(49, 21);
            this.chkPop.TabIndex = 16;
            this.chkPop.Text = "Pop";
            this.chkPop.UseVisualStyleBackColor = true;
            // 
            // chkRock
            // 
            this.chkRock.AutoSize = true;
            this.chkRock.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRock.Location = new System.Drawing.Point(181, 23);
            this.chkRock.Name = "chkRock";
            this.chkRock.Size = new System.Drawing.Size(55, 21);
            this.chkRock.TabIndex = 17;
            this.chkRock.Text = "Rock";
            this.chkRock.UseVisualStyleBackColor = true;
            // 
            // chkMetal
            // 
            this.chkMetal.AutoSize = true;
            this.chkMetal.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMetal.Location = new System.Drawing.Point(20, 23);
            this.chkMetal.Name = "chkMetal";
            this.chkMetal.Size = new System.Drawing.Size(58, 21);
            this.chkMetal.TabIndex = 18;
            this.chkMetal.Text = "Metal";
            this.chkMetal.UseVisualStyleBackColor = true;
            // 
            // chkRap
            // 
            this.chkRap.AutoSize = true;
            this.chkRap.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRap.Location = new System.Drawing.Point(327, 23);
            this.chkRap.Name = "chkRap";
            this.chkRap.Size = new System.Drawing.Size(49, 21);
            this.chkRap.TabIndex = 19;
            this.chkRap.Text = "Rap";
            this.chkRap.UseVisualStyleBackColor = true;
            // 
            // chkFolklore
            // 
            this.chkFolklore.AutoSize = true;
            this.chkFolklore.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFolklore.Location = new System.Drawing.Point(327, 60);
            this.chkFolklore.Name = "chkFolklore";
            this.chkFolklore.Size = new System.Drawing.Size(72, 21);
            this.chkFolklore.TabIndex = 20;
            this.chkFolklore.Text = "Folklore";
            this.chkFolklore.UseVisualStyleBackColor = true;
            // 
            // chkRegae
            // 
            this.chkRegae.AutoSize = true;
            this.chkRegae.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRegae.Location = new System.Drawing.Point(20, 60);
            this.chkRegae.Name = "chkRegae";
            this.chkRegae.Size = new System.Drawing.Size(61, 21);
            this.chkRegae.TabIndex = 21;
            this.chkRegae.Text = "Regae";
            this.chkRegae.UseVisualStyleBackColor = true;
            // 
            // grpEstilo
            // 
            this.grpEstilo.Controls.Add(this.chkMetal);
            this.grpEstilo.Controls.Add(this.chkFolklore);
            this.grpEstilo.Controls.Add(this.chkRegae);
            this.grpEstilo.Controls.Add(this.chkRap);
            this.grpEstilo.Controls.Add(this.chkRock);
            this.grpEstilo.Controls.Add(this.chkPop);
            this.grpEstilo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEstilo.Location = new System.Drawing.Point(18, 221);
            this.grpEstilo.Name = "grpEstilo";
            this.grpEstilo.Size = new System.Drawing.Size(459, 100);
            this.grpEstilo.TabIndex = 22;
            this.grpEstilo.TabStop = false;
            this.grpEstilo.Text = "Estilo Musical";
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Transparent;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(599, 384);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(230, 55);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(835, 384);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(230, 55);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1168, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 25);
            this.btnClose.TabIndex = 25;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 451);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grpEstilo);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.dtFechaNacimiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvPersonas);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1191, 451);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1191, 451);
            this.Name = "frmListPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Personas";
            this.Load += new System.EventHandler(this.frmListPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.grpEstilo.ResumeLayout(false);
            this.grpEstilo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.CheckBox chkPop;
        private System.Windows.Forms.CheckBox chkRock;
        private System.Windows.Forms.CheckBox chkMetal;
        private System.Windows.Forms.CheckBox chkRap;
        private System.Windows.Forms.CheckBox chkFolklore;
        private System.Windows.Forms.CheckBox chkRegae;
        private System.Windows.Forms.GroupBox grpEstilo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnClose;
    }
}