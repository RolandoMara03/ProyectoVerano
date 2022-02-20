
namespace ProyectoFletes.Views
{
    partial class fmCrearContrato
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
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.lblcmbSucursal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtmFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.lblFechaR = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fechaPronost = new System.Windows.Forms.Label();
            this.dtmFechaPronos = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Contrato";
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(22, 91);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(317, 21);
            this.cmbSucursales.TabIndex = 1;
            this.cmbSucursales.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblcmbSucursal
            // 
            this.lblcmbSucursal.AutoSize = true;
            this.lblcmbSucursal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcmbSucursal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmbSucursal.Location = new System.Drawing.Point(18, 93);
            this.lblcmbSucursal.Name = "lblcmbSucursal";
            this.lblcmbSucursal.Size = new System.Drawing.Size(64, 19);
            this.lblcmbSucursal.TabIndex = 2;
            this.lblcmbSucursal.Text = "Sucursal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(18, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 1);
            this.panel1.TabIndex = 3;
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.SystemColors.Control;
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Location = new System.Drawing.Point(18, 153);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(321, 28);
            this.txtMonto.TabIndex = 4;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(18, 162);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(53, 19);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "Monto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(18, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 1);
            this.panel2.TabIndex = 4;
            // 
            // dtmFechaReserva
            // 
            this.dtmFechaReserva.Location = new System.Drawing.Point(18, 239);
            this.dtmFechaReserva.Name = "dtmFechaReserva";
            this.dtmFechaReserva.Size = new System.Drawing.Size(321, 20);
            this.dtmFechaReserva.TabIndex = 6;
            // 
            // lblFechaR
            // 
            this.lblFechaR.AutoSize = true;
            this.lblFechaR.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaR.Location = new System.Drawing.Point(18, 217);
            this.lblFechaR.Name = "lblFechaR";
            this.lblFechaR.Size = new System.Drawing.Size(104, 19);
            this.lblFechaR.TabIndex = 7;
            this.lblFechaR.Text = "Fecha Reserva";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(18, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 1);
            this.panel3.TabIndex = 4;
            // 
            // fechaPronost
            // 
            this.fechaPronost.AutoSize = true;
            this.fechaPronost.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaPronost.Location = new System.Drawing.Point(18, 291);
            this.fechaPronost.Name = "fechaPronost";
            this.fechaPronost.Size = new System.Drawing.Size(139, 19);
            this.fechaPronost.TabIndex = 8;
            this.fechaPronost.Text = "Fecha Pronosticada";
            // 
            // dtmFechaPronos
            // 
            this.dtmFechaPronos.Location = new System.Drawing.Point(18, 313);
            this.dtmFechaPronos.Name = "dtmFechaPronos";
            this.dtmFechaPronos.Size = new System.Drawing.Size(321, 20);
            this.dtmFechaPronos.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Location = new System.Drawing.Point(18, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 1);
            this.panel4.TabIndex = 5;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrear.Location = new System.Drawing.Point(18, 378);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(321, 42);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // fmCrearContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 464);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dtmFechaPronos);
            this.Controls.Add(this.fechaPronost);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblFechaR);
            this.Controls.Add(this.dtmFechaReserva);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblcmbSucursal);
            this.Controls.Add(this.cmbSucursales);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmCrearContrato";
            this.Text = "fmCrearContrato";
            this.Load += new System.EventHandler(this.fmCrearContrato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSucursales;
        private System.Windows.Forms.Label lblcmbSucursal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtmFechaReserva;
        private System.Windows.Forms.Label lblFechaR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label fechaPronost;
        private System.Windows.Forms.DateTimePicker dtmFechaPronos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCrear;
    }
}