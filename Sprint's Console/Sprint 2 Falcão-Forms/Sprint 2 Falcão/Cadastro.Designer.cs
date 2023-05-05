namespace Sprint_2_Falcão
{
    partial class Frm_CadNovo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Lbl_Produto = new System.Windows.Forms.Label();
            this.Lbl_Categoria = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Txt_Prod = new System.Windows.Forms.TextBox();
            this.Txt_Categoria = new System.Windows.Forms.TextBox();
            this.Ckb_Ativo = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Location = new System.Drawing.Point(299, 78);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Id.TabIndex = 1;
            this.Lbl_Id.Text = "label1";
            // 
            // Lbl_Produto
            // 
            this.Lbl_Produto.AutoSize = true;
            this.Lbl_Produto.Location = new System.Drawing.Point(37, 122);
            this.Lbl_Produto.Name = "Lbl_Produto";
            this.Lbl_Produto.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Produto.TabIndex = 2;
            this.Lbl_Produto.Text = "label2";
            // 
            // Lbl_Categoria
            // 
            this.Lbl_Categoria.AutoSize = true;
            this.Lbl_Categoria.Location = new System.Drawing.Point(37, 233);
            this.Lbl_Categoria.Name = "Lbl_Categoria";
            this.Lbl_Categoria.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Categoria.TabIndex = 3;
            this.Lbl_Categoria.Text = "label3";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(355, 75);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(82, 27);
            this.Txt_Id.TabIndex = 4;
            // 
            // Txt_Prod
            // 
            this.Txt_Prod.Location = new System.Drawing.Point(37, 145);
            this.Txt_Prod.Name = "Txt_Prod";
            this.Txt_Prod.Size = new System.Drawing.Size(274, 27);
            this.Txt_Prod.TabIndex = 5;
            // 
            // Txt_Categoria
            // 
            this.Txt_Categoria.Location = new System.Drawing.Point(37, 269);
            this.Txt_Categoria.Name = "Txt_Categoria";
            this.Txt_Categoria.Size = new System.Drawing.Size(274, 27);
            this.Txt_Categoria.TabIndex = 6;
            this.Txt_Categoria.TextChanged += new System.EventHandler(this.Txt_Categoria_TextChanged);
            // 
            // Ckb_Ativo
            // 
            this.Ckb_Ativo.AutoSize = true;
            this.Ckb_Ativo.Location = new System.Drawing.Point(336, 272);
            this.Ckb_Ativo.Name = "Ckb_Ativo";
            this.Ckb_Ativo.Size = new System.Drawing.Size(101, 24);
            this.Ckb_Ativo.TabIndex = 7;
            this.Ckb_Ativo.Text = "checkBox1";
            this.Ckb_Ativo.UseVisualStyleBackColor = true;
            // 
            // Frm_CadNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.Ckb_Ativo);
            this.Controls.Add(this.Txt_Categoria);
            this.Controls.Add(this.Txt_Prod);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.Lbl_Categoria);
            this.Controls.Add(this.Lbl_Produto);
            this.Controls.Add(this.Lbl_Id);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_CadNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Label Lbl_Id;
        private Label Lbl_Produto;
        private Label Lbl_Categoria;
        private TextBox Txt_Id;
        private TextBox Txt_Prod;
        private TextBox Txt_Categoria;
        private CheckBox Ckb_Ativo;
    }
}