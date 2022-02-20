
namespace ProyectoFletes.Views
{
    partial class frmCrearSucursal
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelDireccion = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblComarca = new System.Windows.Forms.Label();
            this.cmbComarca = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.dtmAntiguedad = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Sucursal";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Location = new System.Drawing.Point(34, 116);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(310, 20);
            this.txtDireccion.TabIndex = 1;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDireccion.WordWrap = false;
            this.txtDireccion.Click += new System.EventHandler(this.txtDireccion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(34, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 1);
            this.panel1.TabIndex = 2;
            // 
            // LabelDireccion
            // 
            this.LabelDireccion.AutoSize = true;
            this.LabelDireccion.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDireccion.Location = new System.Drawing.Point(31, 115);
            this.LabelDireccion.Name = "LabelDireccion";
            this.LabelDireccion.Size = new System.Drawing.Size(60, 16);
            this.LabelDireccion.TabIndex = 3;
            this.LabelDireccion.Text = "Direccion";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(37, 177);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(310, 21);
            this.cmbDepartamento.TabIndex = 4;
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.SystemColors.Control;
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Location = new System.Drawing.Point(34, 342);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(310, 20);
            this.txtTel.TabIndex = 9;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTel.WordWrap = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(34, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(31, 157);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(88, 16);
            this.lblDepartamento.TabIndex = 15;
            this.lblDepartamento.Text = "Departamento";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(34, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 1);
            this.panel3.TabIndex = 3;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(31, 219);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(62, 16);
            this.lblMunicipio.TabIndex = 16;
            this.lblMunicipio.Text = "Municipio";
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(38, 237);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(310, 21);
            this.cmbMunicipio.TabIndex = 17;
            this.cmbMunicipio.SelectedIndexChanged += new System.EventHandler(this.cmbMunicipio_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(38, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 1);
            this.panel2.TabIndex = 3;
            // 
            // lblComarca
            // 
            this.lblComarca.AutoSize = true;
            this.lblComarca.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComarca.Location = new System.Drawing.Point(31, 279);
            this.lblComarca.Name = "lblComarca";
            this.lblComarca.Size = new System.Drawing.Size(56, 16);
            this.lblComarca.TabIndex = 18;
            this.lblComarca.Text = "Comarca";
            // 
            // cmbComarca
            // 
            this.cmbComarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbComarca.FormattingEnabled = true;
            this.cmbComarca.Location = new System.Drawing.Point(38, 298);
            this.cmbComarca.Name = "cmbComarca";
            this.cmbComarca.Size = new System.Drawing.Size(310, 21);
            this.cmbComarca.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Location = new System.Drawing.Point(38, 325);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 1);
            this.panel4.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(33, 342);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 16);
            this.lblTelefono.TabIndex = 21;
            this.lblTelefono.Text = "Telefono";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel5.Location = new System.Drawing.Point(36, 370);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 1);
            this.panel5.TabIndex = 3;
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntiguedad.Location = new System.Drawing.Point(33, 388);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(71, 16);
            this.lblAntiguedad.TabIndex = 22;
            this.lblAntiguedad.Text = "Antiguedad";
            // 
            // dtmAntiguedad
            // 
            this.dtmAntiguedad.Location = new System.Drawing.Point(34, 408);
            this.dtmAntiguedad.Name = "dtmAntiguedad";
            this.dtmAntiguedad.Size = new System.Drawing.Size(314, 20);
            this.dtmAntiguedad.TabIndex = 23;
            // 
            // frmCrearSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 524);
            this.Controls.Add(this.dtmAntiguedad);
            this.Controls.Add(this.lblAntiguedad);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.cmbComarca);
            this.Controls.Add(this.lblComarca);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbMunicipio);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.LabelDireccion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearSucursal";
            this.Text = "frmCrearPiloto";
            this.Load += new System.EventHandler(this.frmCrearSucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelDireccion;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblComarca;
        private System.Windows.Forms.ComboBox cmbComarca;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.DateTimePicker dtmAntiguedad;
    }
}