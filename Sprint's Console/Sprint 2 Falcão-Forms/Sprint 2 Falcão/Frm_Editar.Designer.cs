namespace Sprint_2_Falcão
{
    partial class Frm_Editar
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
            this.Ckb_AtivoE = new System.Windows.Forms.CheckBox();
            this.Txt_CategoriaE = new System.Windows.Forms.TextBox();
            this.Txt_ProdE = new System.Windows.Forms.TextBox();
            this.Txt_IdE = new System.Windows.Forms.TextBox();
            this.Lbl_IdE = new System.Windows.Forms.Label();
            this.Lbl_ProdE = new System.Windows.Forms.Label();
            this.Lbl_CategoriaE = new System.Windows.Forms.Label();
            this.Ckb_Inativo = new System.Windows.Forms.CheckBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(477, 28);
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
            // Ckb_AtivoE
            // 
            this.Ckb_AtivoE.AutoSize = true;
            this.Ckb_AtivoE.Location = new System.Drawing.Point(325, 280);
            this.Ckb_AtivoE.Name = "Ckb_AtivoE";
            this.Ckb_AtivoE.Size = new System.Drawing.Size(101, 24);
            this.Ckb_AtivoE.TabIndex = 12;
            this.Ckb_AtivoE.Text = "checkBox1";
            this.Ckb_AtivoE.UseVisualStyleBackColor = true;
            this.Ckb_AtivoE.CheckedChanged += new System.EventHandler(this.Ckb_AtivoE_CheckedChanged);
            // 
            // Txt_CategoriaE
            // 
            this.Txt_CategoriaE.Location = new System.Drawing.Point(26, 277);
            this.Txt_CategoriaE.Name = "Txt_CategoriaE";
            this.Txt_CategoriaE.Size = new System.Drawing.Size(274, 27);
            this.Txt_CategoriaE.TabIndex = 11;
            this.Txt_CategoriaE.TextChanged += new System.EventHandler(this.Txt_CategoriaE_TextChanged);
            // 
            // Txt_ProdE
            // 
            this.Txt_ProdE.Location = new System.Drawing.Point(26, 153);
            this.Txt_ProdE.Name = "Txt_ProdE";
            this.Txt_ProdE.Size = new System.Drawing.Size(274, 27);
            this.Txt_ProdE.TabIndex = 10;
            // 
            // Txt_IdE
            // 
            this.Txt_IdE.Location = new System.Drawing.Point(344, 83);
            this.Txt_IdE.Name = "Txt_IdE";
            this.Txt_IdE.Size = new System.Drawing.Size(82, 27);
            this.Txt_IdE.TabIndex = 9;
            // 
            // Lbl_IdE
            // 
            this.Lbl_IdE.AutoSize = true;
            this.Lbl_IdE.Location = new System.Drawing.Point(288, 86);
            this.Lbl_IdE.Name = "Lbl_IdE";
            this.Lbl_IdE.Size = new System.Drawing.Size(50, 20);
            this.Lbl_IdE.TabIndex = 8;
            this.Lbl_IdE.Text = "label1";
            // 
            // Lbl_ProdE
            // 
            this.Lbl_ProdE.AutoSize = true;
            this.Lbl_ProdE.Location = new System.Drawing.Point(26, 120);
            this.Lbl_ProdE.Name = "Lbl_ProdE";
            this.Lbl_ProdE.Size = new System.Drawing.Size(50, 20);
            this.Lbl_ProdE.TabIndex = 13;
            this.Lbl_ProdE.Text = "label1";
            // 
            // Lbl_CategoriaE
            // 
            this.Lbl_CategoriaE.AutoSize = true;
            this.Lbl_CategoriaE.Location = new System.Drawing.Point(26, 243);
            this.Lbl_CategoriaE.Name = "Lbl_CategoriaE";
            this.Lbl_CategoriaE.Size = new System.Drawing.Size(50, 20);
            this.Lbl_CategoriaE.TabIndex = 14;
            this.Lbl_CategoriaE.Text = "label1";
            // 
            // Ckb_Inativo
            // 
            this.Ckb_Inativo.AutoSize = true;
            this.Ckb_Inativo.Location = new System.Drawing.Point(325, 310);
            this.Ckb_Inativo.Name = "Ckb_Inativo";
            this.Ckb_Inativo.Size = new System.Drawing.Size(101, 24);
            this.Ckb_Inativo.TabIndex = 15;
            this.Ckb_Inativo.Text = "checkBox1";
            this.Ckb_Inativo.UseVisualStyleBackColor = true;
            this.Ckb_Inativo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Frm_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.Ckb_Inativo);
            this.Controls.Add(this.Lbl_CategoriaE);
            this.Controls.Add(this.Lbl_ProdE);
            this.Controls.Add(this.Ckb_AtivoE);
            this.Controls.Add(this.Txt_CategoriaE);
            this.Controls.Add(this.Txt_ProdE);
            this.Controls.Add(this.Txt_IdE);
            this.Controls.Add(this.Lbl_IdE);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cadastro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private CheckBox Ckb_AtivoE;
        private TextBox Txt_CategoriaE;
        private TextBox Txt_ProdE;
        private TextBox Txt_IdE;
        private Label Lbl_IdE;
        private Label Lbl_ProdE;
        private Label Lbl_CategoriaE;
        private CheckBox Ckb_Inativo;
    }
}