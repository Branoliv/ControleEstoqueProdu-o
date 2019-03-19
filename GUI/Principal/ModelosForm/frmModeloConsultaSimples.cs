using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ModelosForm
{
    public partial class frmModeloConsultaSimples : Form
    {
        public frmModeloConsultaSimples()
        {
            InitializeComponent();
        }

        private void frmModeloConsultaSimples_Load(object sender, EventArgs e)
        {
            LblTituloModeloConsultaSimples.Text = this.Text;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmModeloConsultaSimples_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            else if(e.KeyCode == Keys.Escape)
            {
                btnSair_Click(sender, e);
            }
        }
    }
}
