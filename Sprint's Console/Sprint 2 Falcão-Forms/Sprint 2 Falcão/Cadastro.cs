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
    public partial class Frm_CadNovo : Form
    {
        public Frm_CadNovo()
        {
            InitializeComponent();
            Lbl_Categoria.Text = "Categoria";
            Lbl_Id.Text = "ID";
            Lbl_Produto.Text = "Produto";
            Ckb_Ativo.Text = "Ativo";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bool statusA;

          
            statusA = Ckb_Ativo.Checked;

            MessageBox.Show("Status: " + statusA);

            DateTime date = DateTime.Now;


            MessageBox.Show("Data de criação: " + date);

            Frm_Cadastro c = new Frm_Cadastro();
            Txt_Categoria.Clear();
            Txt_Id.Clear();
            Txt_Prod.Clear();
            Ckb_Ativo.Checked = false;


        }

        private void Txt_Categoria_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Categoria.Text.Length > 128)
            {
                MessageBox.Show("Máximo de 128 caracteres - Apenas letras");
            }
            
        }
    }
}
