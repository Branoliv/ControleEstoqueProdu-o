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
    public partial class frmModeloCadastro : Form
    {
        public String operacao;

        public frmModeloCadastro()
        {
            InitializeComponent();
        }

        public void alterabotoes(int op)
        {
            // op = operações que serão feitas com os botões
            // 1  = Preparar os botões para inserir e localizar
            // 2  = Preparar os para inserir/alterar um registro
            // 3  = Preparar a tela para excluir ou alterar
            // 4  = visualização dos itens sem alera

            pnlDados.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;           

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
                
            }
            if (op == 2)
            {
                pnlDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;         
            }
            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if(op == 4)
            {
                pnlDados.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Text = "Estorno";
            }

            if(op == 5)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }
      
        private void frmModeloCadastro_Load(object sender, EventArgs e)
        {           
           alterabotoes(1);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
           frmPrincipal frt = new frmPrincipal();
           ((frmPrincipal)Application.OpenForms["frmPrincipal"]).LblTituloPrincipal.Text = frt.LblTituloPrincipal.Text;
        }

        private void frmModeloCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
