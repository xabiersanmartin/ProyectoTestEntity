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
    public partial class FrmAnadirCategoria : Form
    {
        public FrmAnadirCategoria()
        {
            InitializeComponent();
        }

        private void FrmAnadirCategoria_Load(object sender, EventArgs e)
        {
            List<Categoria> categorias = Program.acceso.DevolverCategorias();

            if (categorias.Count != 0)
            {
                lstCategorias.Items.Clear();
                lstCategorias.Items.AddRange(categorias.ToArray());
                lstCategorias.DisplayMember = "Descripcion";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnadirCategoria_Click(object sender, EventArgs e)
        {
            string msg = Program.acceso.AnadirCategoria(txtNombreCategoria.Text);

            MessageBox.Show(msg);

            txtNombreCategoria.Text = "";

            if (msg == "Categoría añadida correctamente")
            {
                List<Categoria> categorias = Program.acceso.DevolverCategorias();
                lstCategorias.Items.Clear();
                lstCategorias.Items.AddRange(categorias.ToArray());
                lstCategorias.DisplayMember = "Descripcion";
            }
        }
    }
}
