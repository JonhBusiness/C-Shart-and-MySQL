using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect_C_Shart
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
  

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            string USUARIO, PASS;
            USUARIO = txtUsuario.Text.TrimEnd();
            PASS = txtPassword.Text.TrimEnd();
            if (USUARIO == "Juan" && PASS == "123")
            {
                MessageBox.Show("WELCOME");
                this.Hide();
                Forms.System_Form plataforma = new Forms.System_Form();
                plataforma.Show();
            }
            else
            {
                MessageBox.Show("DATOS INCORRECTOS");
                txtUsuario.Text = "";
                txtPassword.Text = "";

            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
