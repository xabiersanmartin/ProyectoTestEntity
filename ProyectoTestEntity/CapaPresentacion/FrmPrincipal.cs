using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        bool comprobar = false;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            List<Categoria> categorias = Program.acceso.DevolverCategorias();
            if (categorias.Count == 0)
            {
                comprobar = true;
            }
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            if (comprobar == true)
            {
                MessageBox.Show("No tienes categorías debes añadirlas para poder entrar aquí","ATENCIÓN");
                return;
            }
        }

        private void añadirCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnadirCategoria frm = new FrmAnadirCategoria();
            frm.ShowDialog(this);
        }
    }
}
