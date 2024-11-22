namespace telas
{
    partial class servicospendetes
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            excluir = new Button();
            deletar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            clintmoto = new Label();
            clintname = new Label();
            serv_Pend = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 39);
            label1.Name = "label1";
            label1.Size = new Size(381, 37);
            label1.TabIndex = 0;
            label1.Text = "Serviços Disponiveis:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(842, 283);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // excluir
            // 
            excluir.Location = new Point(40, 432);
            excluir.Name = "excluir";
            excluir.Size = new Size(237, 67);
            excluir.TabIndex = 31;
            excluir.Text = "Voltar Menu";
            excluir.UseVisualStyleBackColor = true;
            excluir.Click += excluir_Click;
            // 
            // deletar
            // 
            deletar.Location = new Point(644, 432);
            deletar.Name = "deletar";
            deletar.Size = new Size(238, 67);
            deletar.TabIndex = 32;
            deletar.Text = "Pegar serviço";
            deletar.UseVisualStyleBackColor = true;
            deletar.Visible = false;
            deletar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            label2.Location = new Point(966, 128);
            label2.Name = "label2";
            label2.Size = new Size(237, 37);
            label2.TabIndex = 33;
            label2.Text = "Nome Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            label3.Location = new Point(963, 184);
            label3.Name = "label3";
            label3.Size = new Size(240, 37);
            label3.TabIndex = 34;
            label3.Text = "Moto Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold);
            label4.Location = new Point(888, 232);
            label4.Name = "label4";
            label4.Size = new Size(315, 37);
            label4.TabIndex = 35;
            label4.Text = "Serviço Pendente";
            // 
            // clintmoto
            // 
            clintmoto.AutoSize = true;
            clintmoto.Location = new Point(1225, 199);
            clintmoto.Name = "clintmoto";
            clintmoto.Size = new Size(50, 20);
            clintmoto.TabIndex = 37;
            clintmoto.Text = "label6";
            // 
            // clintname
            // 
            clintname.AutoSize = true;
            clintname.Location = new Point(1225, 143);
            clintname.Name = "clintname";
            clintname.Size = new Size(50, 20);
            clintname.TabIndex = 36;
            clintname.Text = "label7";
            // 
            // serv_Pend
            // 
            serv_Pend.AutoSize = true;
            serv_Pend.Location = new Point(1225, 247);
            serv_Pend.Name = "serv_Pend";
            serv_Pend.Size = new Size(50, 20);
            serv_Pend.TabIndex = 38;
            serv_Pend.Text = "label5";
            // 
            // servicospendetes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1333, 649);
            Controls.Add(serv_Pend);
            Controls.Add(clintmoto);
            Controls.Add(clintname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(deletar);
            Controls.Add(excluir);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "servicospendetes";
            Text = "servicospendetes";
            Load += servicospendetes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button excluir;
        private Button deletar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label clintmoto;
        private Label clintname;
        private Label serv_Pend;
    }
}