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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection conexion = new MySqlConnection("datasource=localhost;port=3306;username=root;password=12345678;");
                MySqlDataAdapter adapter = new MySqlDataAdapter("INSERT INTO practicamysql.proveedor(Nombre, Direccion)" + " VALUES('" + txtProveedor.Text + "','" + txtDireccion.Text + "') ",conexion);
                MySqlDataAdapter adapter2 = new MySqlDataAdapter("INSERT INTO practicamysql.productos(Nombre,Descripcion, Precio,Cantidad , Codigo_Proveedor)" + "VALUES ('" + txtProducto.Text + "','" + txtDescripcion.Text + "', '" + txtPrecio.Text + "','" + txtCantidad.Text  + "', LAST_INSERT_ID())", conexion);

                conexion.Open();
                DataSet ds2 = new DataSet();
                DataSet ds = new DataSet();
                if (adapter.Fill(ds, "practicamysql.proveedor") != 1) 
                {

                    if (adapter2.Fill(ds2, "practicamysql.productos") != 1)
                    {
                        MessageBox.Show("Agregado con Exito..", "EXITOSO..", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        MessageBox.Show("Producto no Ingresado","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    }
                }

                else
                {

                    MessageBox.Show("Proveedor no Ingresado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
