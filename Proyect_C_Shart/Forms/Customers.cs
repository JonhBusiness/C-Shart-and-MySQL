using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Proyect_C_Shart.Forms
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
            
        }

        private async void FormCustomers_Load(object sender, EventArgs e)
        {
            
            try
            {
                // Ocultar la tabla y mostrar el GIF de carga
                if (pictureBox1.Visible == true)
                {
                    pictureBox1.Visible = true;
                    dataGridView1.Visible = false;
                 

                    MySqlConnection conexion = new MySqlConnection("datasource=localhost;port=3306;username=root;password=12345678;");
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT i.Codigo_Producto,i.Nombre AS Producto ,i.Cantidad,i.Precio,j.Nombre AS Proveedor,j.Direccion,i.Descripcion FROM practicamysql.productos AS i INNER JOIN practicamysql.proveedor AS j ON i.Codigo_Proveedor=j.Codigo", conexion);

                    DataSet ds = new DataSet();
                    await Task.Run(() => adapter.Fill(ds, "practicamysql"));

                    dataGridView1.DataSource = ds.Tables["practicamysql"];

                    dataGridView1.Visible = true;
                    pictureBox1.Visible = false;
                }
                else
                {
                    dataGridView1.Visible = false;
                    pictureBox1.Visible = true;
                    FormCustomers_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

       
    }
}
