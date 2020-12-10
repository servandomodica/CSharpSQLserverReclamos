using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPracticoParcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mantenimientoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoClientes m = new MantenimientoClientes();
            m.ShowDialog();
        }

        private void cargaDeReclamosDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargaReclamo c = new CargaReclamo();
            c.ShowDialog();
        }

        private void listadoDeReclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoReclamos l = new ListadoReclamos();
            l.ShowDialog();
        }

        private void reclamosPorTécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReclamosPorTecnico r = new ReclamosPorTecnico();
            r.ShowDialog();
        }

        private void reclamosPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReclamosPorCliente r = new ReclamosPorCliente();
            r.ShowDialog();
        }
    }
}
