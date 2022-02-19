using ProyectoFletes.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFletes.Views
{
    public partial class frmCrearProducto : Form
    {
        public Conexion con;
        public DProducto dProducto;
        public frmCrearProducto()
        {
            InitializeComponent();
            CargarClientes();
        }

        public frmCrearProducto (Conexion con)
        {
            InitializeComponent();
            this.con = con;
            CargarClientes();
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCrearProducto_Load(object sender, EventArgs e)
        {

        }

        private void CargarClientes()
        {
            try
            {
                DProducto dProducto = new DProducto(con);
                dProducto.CargarClientes();
                //cmbClientes.DataSource = dProducto.CargarClientes();

            }catch(Exception ex)
            {

            }
            cmbClientes.DisplayMember = "NombreC";
            cmbClientes.ValueMember = "NombreC";
        }
    }
}
