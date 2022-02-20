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
    public partial class FrmMain : Form
    {
         Conexion con;
        Prueba p;
        frmCrearSucursal cs;
        public DataTable dataEmpleado = new DataTable();
        public FrmMain()
        {
            
            InitializeComponent();
        }
        public FrmMain(Conexion cone)
        {
           
            InitializeComponent();
            this.con = cone;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPilotos_Click(object sender, EventArgs e)
        {
            pnlSubMenuPiloto.Visible = true;

            cs= new frmCrearSucursal(con);
            cs.Show();
        }

        private void btnCrearPi_Click(object sender, EventArgs e)
        {
            pnlSubMenuPiloto.Visible = false;
        }

        private void btnVerPilotos_Click(object sender, EventArgs e)
        {
            pnlSubMenuPiloto.Visible = false; 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar el sistema!");
            Application.Exit();
        }
    }
}
