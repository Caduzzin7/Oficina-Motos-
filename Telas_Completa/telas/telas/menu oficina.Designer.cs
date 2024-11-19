namespace telas
{
    partial class menu_oficina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_oficina));
            excluir = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // excluir
            // 
            excluir.BackColor = Color.Transparent;
            excluir.ForeColor = Color.Black;
            excluir.Location = new Point(78, 440);
            excluir.Name = "excluir";
            excluir.Size = new Size(98, 45);
            excluir.TabIndex = 34;
            excluir.Text = "oficina";
            excluir.UseVisualStyleBackColor = false;
            excluir.Click += excluir_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(488, 239);
            button1.Name = "button1";
            button1.Size = new Size(138, 47);
            button1.TabIndex = 38;
            button1.Text = "Cliente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(490, 47);
            label1.Name = "label1";
            label1.Size = new Size(367, 47);
            label1.TabIndex = 39;
            label1.Text = "oficina MyMotos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(511, 9);
            label2.Name = "label2";
            label2.Size = new Size(330, 47);
            label2.TabIndex = 40;
            label2.Text = "Seja Bem Vindo";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(540, 477);
            button2.Name = "button2";
            button2.Size = new Size(96, 28);
            button2.TabIndex = 41;
            button2.Text = "sobre nós";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menu_oficina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1354, 843);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(excluir);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlLight;
            Name = "menu_oficina";
            Text = "menu_oficina";
            Load += menu_oficina_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button excluir;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}