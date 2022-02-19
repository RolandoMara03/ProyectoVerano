
using ProyectoFletes.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFletes.Data;
using System.Threading;

namespace ProyectoFletes
{
    public partial class Form1 : Form
    {
        Conexion con;
        FrmMain f1;
        int cont =3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar el sistema!");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
       
            // Aqui faltan los roles jaja
            // aqui estan cochon jajaj
            con = new Conexion(txtUsername.Text, txtPassword.Text);
    
            if (this.con.connect.State == ConnectionState.Open)
            {
                MessageBox.Show("Bienvenido al sistema!");
                f1 = new FrmMain(con);

                    f1.Show();
                    this.Hide();
            }else
            {              
                --cont;
                MessageBox.Show("Error:usuario o contrasenia incorrecta ", cont + " Intentos restantes");
                if (cont == 0)
                {
                    cont = 3;
                    button1.Enabled = false;
                    Thread.Sleep(3000);
                    button1.Enabled = true;

                }
            }

        }
    }
}
