using ProyectoFletes.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFletes.Views
{
    public partial class frmCrearSucursal : Form
    {
        public Conexion con;
        public frmCrearSucursal()
        {    
            InitializeComponent(); 
        }
        public frmCrearSucursal(Conexion con)
        {
           
            InitializeComponent();
            this.con = con;
        }

        private void CargarDepartamentos()
        {

            try
            {

                cmbDepartamento.DataSource = con.CmbDep();
            }
            catch (Exception)
            {
               
            }
            cmbDepartamento.DisplayMember="NombreDep";
            cmbDepartamento.ValueMember = "NombreDep";
            
           
        }

        private void CargarMunicipios()
        {
          
            cmbMunicipio.DisplayMember = "NombreMuni";
            cmbMunicipio.ValueMember = "NombreMuni";
            cmbMunicipio.DataSource = con.CargarMuni(cmbDepartamento.SelectedIndex+1);
        }

        private void CargarComarca()
        {
            
            
            cmbComarca.DisplayMember = "NombreComa";
            cmbComarca.ValueMember = "NombreComa";
            cmbComarca.DataSource = con.CargarComa(cmbMunicipio.SelectedIndex + 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCrearSucursal_Load(object sender, EventArgs e)
        {
            // CargarDepartamentos();
            CargarDepartamentos();
            
        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {
            LabelDireccion.Hide();
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMunicipios();
        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComarca();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string Direccion = txtDireccion.Text;
            int Comarca = cmbComarca.SelectedIndex + 1;
            DateTime fechaAntiguedad = dtmAntiguedad.Value;
            char Tel = Convert.ToChar(txtTel.Text);
            */
             //Aqui hacer un metodo de validar 
             if(txtDireccion.Text == "")
            {
                MessageBox.Show("Por favor, digite el campo obligatorio Direccion");
            }
            if (txtTel.Text == "")
            {
                MessageBox.Show("Por favor, digite el campo obligatorio Telefono");
            }
            if (cmbDepartamento.Text == "")
            {
                MessageBox.Show("Por favor, seleccione un departamento");
            }
            if (cmbComarca.Text == "")
            {
                MessageBox.Show("Por favor, seleccione una comarca");
            }
            if (cmbMunicipio.Text == "")
            {
                MessageBox.Show("Por favor, seleccione un municipio");
            }
        }
    }
}
