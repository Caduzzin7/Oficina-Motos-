﻿namespace telas
{
    partial class sobrenos
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
            label8 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(332, 21);
            label8.Name = "label8";
            label8.Size = new Size(88, 21);
            label8.TabIndex = 18;
            label8.Text = "Sobre nós ";
            label8.Click += label8_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(31, 395);
            button2.Name = "button2";
            button2.Size = new Size(98, 28);
            button2.TabIndex = 42;
            button2.Text = "Voltar Menu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // sobrenos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label8);
            Name = "sobrenos";
            Text = "sobrenos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button button2;
    }
}