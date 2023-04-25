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
            columnas();
            cboHelp.Items.Add("Yes");
            cboHelp.Items.Add("No");
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Daily seleccionado;
            seleccionado = (Daily)dgvDaily.CurrentRow.DataBoundItem;

            frmDetalle detalle = new frmDetalle(seleccionado);
            detalle.ShowDialog();
            //cargar();
        }

        private void dgvDaily_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDaily.CurrentRow != null)
            {
                Daily seleccionado = (Daily)dgvDaily.CurrentRow.DataBoundItem;
            }
        }
    }
}
