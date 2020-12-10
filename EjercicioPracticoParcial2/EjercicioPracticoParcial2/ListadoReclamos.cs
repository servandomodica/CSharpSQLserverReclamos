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
    public partial class ListadoReclamos : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=SAM; Initial Catalog=bd1; Integrated security=True");
        public ListadoReclamos()
        {
            InitializeComponent();
        }

        private void ListadoReclamos_Load(object sender, EventArgs e)
        {
            CargarDataGridView1();
        }

        private void CargarDataGridView1()
        {
            conexion.Open();

            string sql = "select dnicliente, cli.nombre as nombrecliente, dnitecnico, tec.nombre as nombretecnico, fecha, descripcionreclamo, atendido from reclamos as re" +
                "           inner join clientes as cli on cli.dni = re.dnicliente   " +
                "           inner join tecnicos as tec on tec.dni = re.dnitecnico";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["dnicliente"].ToString(),
                                       registros["nombrecliente"].ToString(),
                                       registros["dnitecnico"].ToString(),
                                       registros["nombretecnico"].ToString(),
                                       registros["fecha"].ToString(),
                                       registros["descripcionreclamo"].ToString(),
                                       registros["atendido"].ToString());
            }

            conexion.Close();
        }
    }
}
