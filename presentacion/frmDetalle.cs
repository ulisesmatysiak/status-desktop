using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmDetalle : Form
    {
        private Daily daily = null;
        public frmDetalle()
        {
            InitializeComponent();
        }

        public frmDetalle(Daily daily)
        {
            InitializeComponent();
            this.daily = daily;
        }
        private void frmDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                if (daily != null)
                {
                    dtpFecha.Value = daily.Fecha;
                    //numStatus.Value = int.Parse(daily.Score);
                    txtWords.Text = daily.Words;
                    cboHelp.ValueMember = "Helped";
                    cboHelp.DisplayMember = "Helped";
                    
                    //cboHelp.SelectedValue = daily.Helped;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }
    }
}
