
namespace EjercicioPracticoParcial2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeReclamosDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeReclamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamosPorTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamosPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeClientesToolStripMenuItem,
            this.cargaDeReclamosDeClientesToolStripMenuItem,
            this.listadoDeReclamosToolStripMenuItem,
            this.reclamosPorTécnicoToolStripMenuItem,
            this.reclamosPorClienteToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mantenimientoDeClientesToolStripMenuItem
            // 
            this.mantenimientoDeClientesToolStripMenuItem.Name = "mantenimientoDeClientesToolStripMenuItem";
            this.mantenimientoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.mantenimientoDeClientesToolStripMenuItem.Text = "Mantenimiento de Clientes";
            this.mantenimientoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeClientesToolStripMenuItem_Click);
            // 
            // cargaDeReclamosDeClientesToolStripMenuItem
            // 
            this.cargaDeReclamosDeClientesToolStripMenuItem.Name = "cargaDeReclamosDeClientesToolStripMenuItem";
            this.cargaDeReclamosDeClientesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.cargaDeReclamosDeClientesToolStripMenuItem.Text = "Carga de reclamos de Clientes";
            this.cargaDeReclamosDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cargaDeReclamosDeClientesToolStripMenuItem_Click);
            // 
            // listadoDeReclamosToolStripMenuItem
            // 
            this.listadoDeReclamosToolStripMenuItem.Name = "listadoDeReclamosToolStripMenuItem";
            this.listadoDeReclamosToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.listadoDeReclamosToolStripMenuItem.Text = "Listado de reclamos";
            this.listadoDeReclamosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeReclamosToolStripMenuItem_Click);
            // 
            // reclamosPorTécnicoToolStripMenuItem
            // 
            this.reclamosPorTécnicoToolStripMenuItem.Name = "reclamosPorTécnicoToolStripMenuItem";
            this.reclamosPorTécnicoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.reclamosPorTécnicoToolStripMenuItem.Text = "Reclamos por técnico";
            this.reclamosPorTécnicoToolStripMenuItem.Click += new System.EventHandler(this.reclamosPorTécnicoToolStripMenuItem_Click);
            // 
            // reclamosPorClienteToolStripMenuItem
            // 
            this.reclamosPorClienteToolStripMenuItem.Name = "reclamosPorClienteToolStripMenuItem";
            this.reclamosPorClienteToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.reclamosPorClienteToolStripMenuItem.Text = "Reclamos por cliente";
            this.reclamosPorClienteToolStripMenuItem.Click += new System.EventHandler(this.reclamosPorClienteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeReclamosDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeReclamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reclamosPorTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reclamosPorClienteToolStripMenuItem;
    }
}

