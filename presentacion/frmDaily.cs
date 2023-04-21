using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmDaily : Form
    {
        List<Daily> listaDaily;
        public frmDaily()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            DailyNegocio negocio = new DailyNegocio();

            try
            {
                listaDaily = negocio.listar();
                dgvDaily.DataSource = listaDaily;
                columnas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void columnas()
        {
            dgvDaily.Columns["Id"].Visible = false;
            dgvDaily.Columns["Fecha"].Width = 75;
            dgvDaily.Columns["Score"].Width = 50;
            dgvDaily.Columns["Words"].Visible = false;
            dgvDaily.Columns["Helped"].Width = 50;
        }

        private void frmDaily_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            frmDetalle detalle = new frmDetalle();
            detalle.ShowDialog();
        }
    }
}
