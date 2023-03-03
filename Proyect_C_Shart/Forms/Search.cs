using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyect_C_Shart.Forms
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }
        private void FormSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection conexion = new MySqlConnection("datasource=localhost;port=3306;username=root;password=12345678;");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM practicamysql.proveedor WHERE practicamysql.proveedor.Nombre LIKE '%" + txtBuscarNom.Text + "%'", conexion);

                conexion.Open();
                DataSet ds = new DataSet();
                if (adapter.Fill(ds, "practicamysql") != 1)
                {
                    adapter.Fill(ds, "practicamysql");
                    dataGridView2.DataSource = ds.Tables["practicamysql"];
                }
                else
                {
                    MessageBox.Show("NO hay nadie con ese nombre");
                }
                conexion.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
    
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //MUESTRA LA CELDA Y ID SELECIONADO
            txtID.Value = (int)dataGridView2.CurrentRow.Cells["Codigo"].Value;
            txtBuscarNom.Text = (string)dataGridView2.CurrentRow.Cells["Nombre"].Value;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            try
            {

                MySqlConnection conexion = new MySqlConnection("datasource=localhost;port=3306;username=root;password=12345678;");
                MySqlDataAdapter adapter = new MySqlDataAdapter("DELETE FROM practicamysql.proveedor WHERE Codigo =" + txtID.Value + ";", conexion);

                conexion.Open();

                DataSet ds = new DataSet();
                if (adapter.Fill(ds, "practicamysql.proveedor") != 1)
                {


                    MessageBox.Show("CLIENTE ELIMINADO");

                }

                else
                {

                    MessageBox.Show("NO SE PUDO ELIMINAR");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}