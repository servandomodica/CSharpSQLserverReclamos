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
    public partial class ReclamosPorTecnico : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=SAM; Initial Catalog=bd1; Integrated security=True");

        public ReclamosPorTecnico()
        {
            InitializeComponent();
        }

        private void ReclamosPorTecnico_Load(object sender, EventArgs e)
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
            conexion.Open();

            string sql = "select dnicliente, cli.nombre as nombrecliente, fecha, descripcionreclamo, domicilio, atendido from reclamos as re " +
                "             inner join clientes as cli on cli.dni = re.dnicliente   " +
                "             where dnitecnico=@dnitecnico";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@dnitecnico", SqlDbType.Char).Value = comboBox1.SelectedValue;

            SqlDataReader registros = comando.ExecuteReader();

            dataGridView1.Rows.Clear();
            while( registros.Read())
            {
                dataGridView1.Rows.Add(registros["dnicliente"].ToString(),
                                       registros["nombrecliente"].ToString(),
                                       registros["fecha"].ToString(),
                                       registros["descripcionreclamo"].ToString(),
                                       registros["domicilio"].ToString(),
                                       registros["atendido"].ToString());
            }

            registros.Close();
            conexion.Close();
        }
    }
}
