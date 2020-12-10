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

namespace EjercicioPracticoParcial2
{
    public partial class MantenimientoClientes : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=SAM; Initial Catalog=bd1; Integrated security=True");

        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "insert into clientes(dni,nombre,domicilio) values(@dni,@nombre,@domicilio)";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@dni", SqlDbType.Char).Value = textBox1.Text;
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textBox2.Text;
            comando.Parameters.Add("@domicilio", SqlDbType.VarChar).Value = textBox3.Text;

            comando.ExecuteNonQuery();

            conexion.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            MessageBox.Show("Los datos del cliente fueron cargados");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "select nombre, domicilio from clientes where dni=@dni";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@dni", SqlDbType.Char).Value = textBox1.Text;

            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                textBox2.Text = registro["nombre"].ToString();
                textBox3.Text = registro["domicilio"].ToString();
            }
            else
            {
                MessageBox.Show("No existe un cliente con dicho dni");
            }

            registro.Close();
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "update clientes set nombre=@nombre, domicilio=@domicilio where dni=@dni";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textBox2.Text;
            comando.Parameters.Add("@domicilio", SqlDbType.VarChar).Value = textBox3.Text;
            comando.Parameters.Add("@dni", SqlDbType.Char).Value = textBox1.Text;

            int cant = comando.ExecuteNonQuery();

            if (cant == 1)
                MessageBox.Show("Los datos fueron modificado");
            else
                MessageBox.Show("No existe un cliente con dicho dni");

            conexion.Close();
        }

        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
