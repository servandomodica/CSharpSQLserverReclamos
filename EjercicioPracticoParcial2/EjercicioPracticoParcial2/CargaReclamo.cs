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
    public partial class CargaReclamo : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=SAM; Initial Catalog=bd1; Integrated security=True");

        public CargaReclamo()
        {
            InitializeComponent();
        }

        private void CargaReclamo_Load(object sender, EventArgs e)
        {
            cargarComboBox1();
        }

        private void cargarComboBox1()
        {
            conexion.Open();

            string sql = "select dni,nombre from tecnicos";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);

            comboBox1.DataSource = tabla1;
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "dni";

            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ExisteCliente(textBox1.Text))
            {
                conexion.Open();

                string sql = "insert into reclamos(dnicliente,dnitecnico,fecha,descripcionreclamo) values (@dnicliente,@dnitecnico,@fecha,@descripcionreclamo)";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.Add("@dnicliente", SqlDbType.Char).Value = textBox1.Text;
                comando.Parameters.Add("@dnitecnico", SqlDbType.Char).Value = comboBox1.SelectedValue;
                comando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                comando.Parameters.Add("@descripcionreclamo", SqlDbType.VarChar).Value = textBox2.Text;

                comando.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("El reclamo fue registrado");
            }
            else
                MessageBox.Show("Dni de cliente inexistente");
        }

        private bool ExisteCliente(string dni)
        {
            bool existe = false;

            conexion.Open();

            string sql = "select nombre from clientes where dni=@dni";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@dni", SqlDbType.Char).Value = dni;

            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
                existe = true;

            conexion.Close();

            return existe;
        }
    }
}
