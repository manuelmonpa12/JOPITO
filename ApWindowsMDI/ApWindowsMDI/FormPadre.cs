using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApWindowsMDI
{
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();
        }

        private void ArchivoNuevo_Click(object sender, EventArgs e)
        {
            FormHijo NuevoFormHijo = new FormHijo();

            NuevoFormHijo.Text = "Form" + MdiChildren.Length.ToString();

            NuevoFormHijo.MdiParent = this;

            NuevoFormHijo.Show();
        }

        private void ArchivoCerrar_Click(object sender, EventArgs e)
        {
            FormHijo FormHijoActivo = (FormHijo)ActiveMdiChild;

            if (FormHijoActivo != null)
            {
                FormHijoActivo.Close();
            }
        }

        private void VentanaCascada_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void VentanaHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void VentanaVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void ArchivoSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
