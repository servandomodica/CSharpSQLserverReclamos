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
    public partial class ReclamosPorCliente : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=SAM; Initial Catalog=bd1; Integrated security=True");

        public ReclamosPorCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "select dnitecnico, tec.nombre as nombretecnico, fecha, descripcionreclamo, atendido from reclamos as re" +
                "            inner join tecnicos as tec on tec.dni = re.dnitecnico  " +
                "            where dnicliente = @dnicliente";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@dnicliente", SqlDbType.Char).Value = textBox1.Text;

            SqlDataReader registros = comando.ExecuteReader();

            dataGridView1.Rows.Clear();
            bool existe = false;
            while(registros.Read())
            {
                dataGridView1.Rows.Add(registros["dnitecnico"].ToString(),
                                       registros["nombretecnico"].ToString(),
                                       registros["fecha"].ToString(),
                                       registros["descripcionreclamo"].ToString(),
                                       registros["atendido"].ToString());
                existe = true;
            }

            registros.Close();
            conexion.Close();

            if (!existe)
                MessageBox.Show("No hay reclamos de la persona con dni " + textBox1.Text);
        }
    }
}
