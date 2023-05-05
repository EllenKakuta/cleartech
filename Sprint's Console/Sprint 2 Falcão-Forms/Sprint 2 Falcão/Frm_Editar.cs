using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint_2_Falcão
{
    public partial class Frm_Editar : Form
    {
        public Frm_Editar()
        {
            InitializeComponent();
            Lbl_CategoriaE.Text = "Categoria";
            Lbl_IdE.Text = "ID";
            Lbl_ProdE.Text = "Produto";
            Ckb_AtivoE.Text = "Ativo";
            Ckb_Inativo.Text = "Inativo";

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckb_Inativo.Checked == true)
            {
                Ckb_AtivoE.Enabled = false;
            }
            else
            {
                Ckb_AtivoE.Enabled = true;
            }
        }

        private void Ckb_AtivoE_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckb_AtivoE.Checked == true)
            {
                Ckb_Inativo.Enabled = false;
            }
            else
            {
                Ckb_Inativo.Enabled = true;
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool statusAE;
            bool statusIn;

            statusAE = Ckb_AtivoE.Checked;
            statusIn = Ckb_Inativo.Checked;

            MessageBox.Show("Status: " + "Ativo"+statusAE + " Inativo" + statusIn);

            DateTime date = DateTime.Now;


            MessageBox.Show("Data de criação: " + date);

            Txt_CategoriaE.Clear();
            Txt_IdE.Clear();
            Txt_ProdE.Clear();
            Ckb_AtivoE.Checked = false;
            Ckb_Inativo.Checked = false;
        }

        private void Txt_CategoriaE_TextChanged(object sender, EventArgs e)
        {
            if (Txt_CategoriaE.Text.Length > 128)
            {
                MessageBox.Show("Máximo de 128 caracteres - Apenas letras");
                
            }
        }
    }
}
