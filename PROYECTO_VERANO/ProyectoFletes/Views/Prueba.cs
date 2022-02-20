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
    public partial class Prueba : Form
    {
        public Conexion con;
        public Prueba()
        {
            InitializeComponent();
        }
        public Prueba(Conexion conee)
        {
            
            InitializeComponent();
            this.con = conee;
        }


        private void Prueba_Load(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.DataSource = con.CmbDep();
            }
            catch (Exception  )
            {
                MessageBox.Show("Excepcion fue: " + e);
            }
        }
    }
}
