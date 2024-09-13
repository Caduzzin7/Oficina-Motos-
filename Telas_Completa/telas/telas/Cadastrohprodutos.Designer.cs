namespace telas
{
    partial class Cadastrohprodutos
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
            label7 = new Label();
            label8 = new Label();
            descricaogeralproduto = new TextBox();
            anodapeca = new TextBox();
            precototal = new TextBox();
            nomedoproduto = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cadastrar = new Button();
            excluir = new Button();
            editar = new Button();
            proximatela = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(327, 20);
            label7.Name = "label7";
            label7.Size = new Size(226, 53);
            label7.TabIndex = 20;
            label7.Text = "cadastro peças";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(305, 82);
            label8.Name = "label8";
            label8.Size = new Size(194, 21);
            label8.TabIndex = 21;
            label8.Text = "Informações do produto:";
            // 
            // descricaogeralproduto
            // 
            descricaogeralproduto.BackColor = Color.White;
            descricaogeralproduto.Location = new Point(305, 221);
            descricaogeralproduto.Name = "descricaogeralproduto";
            descricaogeralproduto.Size = new Size(292, 27);
            descricaogeralproduto.TabIndex = 24;
            // 
            // anodapeca
            // 
            anodapeca.BackColor = Color.White;
            anodapeca.Location = new Point(305, 270);
            anodapeca.Name = "anodapeca";
            anodapeca.Size = new Size(292, 27);
            anodapeca.TabIndex = 25;
            // 
            // precototal
            // 
            precototal.BackColor = Color.White;
            precototal.Location = new Point(305, 314);
            precototal.Name = "precototal";
            precototal.Size = new Size(292, 27);
            precototal.TabIndex = 26;
            // 
            // nomedoproduto
            // 
            nomedoproduto.BackColor = Color.White;
            nomedoproduto.Location = new Point(305, 179);
            nomedoproduto.Name = "nomedoproduto";
            nomedoproduto.Size = new Size(292, 27);
            nomedoproduto.TabIndex = 27;
            nomedoproduto.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 317);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 28;
            label4.Text = "Preco Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 273);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 29;
            label1.Text = "Ano da Peca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 224);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 30;
            label2.Text = "Descricao Geral:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 186);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 31;
            label3.Text = "Nome Produtos:";
            // 
            // cadastrar
            // 
            cadastrar.Location = new Point(443, 409);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(134, 29);
            cadastrar.TabIndex = 32;
            cadastrar.Text = "cadastrar:";
            cadastrar.UseVisualStyleBackColor = true;
            cadastrar.Click += button1_Click;
            // 
            // excluir
            // 
            excluir.Location = new Point(210, 409);
            excluir.Name = "excluir";
            excluir.Size = new Size(94, 29);
            excluir.TabIndex = 33;
            excluir.Text = "excluir";
            excluir.UseVisualStyleBackColor = true;
            excluir.Click += excluir_Click;
            // 
            // editar
            // 
            editar.Location = new Point(327, 409);
            editar.Name = "editar";
            editar.Size = new Size(94, 29);
            editar.TabIndex = 34;
            editar.Text = "editar:";
            editar.UseVisualStyleBackColor = true;
            editar.Click += button1_Click_1;
            // 
            // proximatela
            // 
            proximatela.Location = new Point(610, 409);
            proximatela.Name = "proximatela";
            proximatela.Size = new Size(141, 29);
            proximatela.TabIndex = 35;
            proximatela.Text = "ir para o relatorio:";
            proximatela.UseVisualStyleBackColor = true;
            proximatela.Click += button2_Click;
            // 
            // Cadastrohprodutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(941, 535);
            Controls.Add(proximatela);
            Controls.Add(editar);
            Controls.Add(excluir);
            Controls.Add(cadastrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(nomedoproduto);
            Controls.Add(precototal);
            Controls.Add(anodapeca);
            Controls.Add(descricaogeralproduto);
            Controls.Add(label8);
            Controls.Add(label7);
            Name = "Cadastrohprodutos";
            Text = "Cadastrohprodutos";
            Load += Cadastrohprodutos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label8;
        private TextBox descricaogeralproduto;
        private TextBox anodapeca;
        private TextBox precototal;
        private TextBox nomedoproduto;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button cadastrar;
        private Button excluir;
        private Button editar;
        private Button proximatela;
    }
}