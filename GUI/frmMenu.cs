using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMenu : Form
    {
        Form fr;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.LblTituloMdi.Text = this.Text;
        }

        private void FecharFormulariosFilhos()
        {
            // percorre todos os formulários abertos
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // se o formulário for filho
                if (Application.OpenForms[i].IsMdiChild)
                {
                    // fecha o formulário
                    Application.OpenForms[i].Close();
                }
            }
        }

        void fr_FormClosed(object sender, EventArgs e)
        {
            fr = null;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            //    FecharFormulariosFilhos();

            //if (fr == null)
            //    {
                  frmPrincipal  Objfr = new frmPrincipal ();
            Objfr.clienteToolStripMenuItem.PerformClick();
                //    fr.MdiParent = this.ParentForm;
                //    fr.FormClosed += new FormClosedEventHandler(fr_FormClosed);
                //    fr.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                //    fr.Show();
                //}            
        }
       
        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            if (fr == null)
            {
                fr = new frmFornecedor();
                fr.MdiParent = this.ParentForm;
                fr.FormClosed += new FormClosedEventHandler(fr_FormClosed);
                fr.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                fr.Show();
            }

        }
    }    
}

