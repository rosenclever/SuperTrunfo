namespace SuperTrunfo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            lblCartasJogador = new Label();
            lblJogadorVelocidade = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblCartasComputador = new Label();
            lblComputadorVelocidade = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(1, 1, 1, 1);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(583, 356);
            splitContainer1.SplitterDistance = 293;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCartasJogador);
            groupBox1.Controls.Add(lblJogadorVelocidade);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 30);
            groupBox1.Margin = new Padding(1, 1, 1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1, 1, 1, 1);
            groupBox1.Size = new Size(278, 395);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jogador";
            // 
            // lblCartasJogador
            // 
            lblCartasJogador.AutoSize = true;
            lblCartasJogador.Location = new Point(21, 38);
            lblCartasJogador.Margin = new Padding(1, 0, 1, 0);
            lblCartasJogador.Name = "lblCartasJogador";
            lblCartasJogador.Size = new Size(0, 15);
            lblCartasJogador.TabIndex = 2;
            // 
            // lblJogadorVelocidade
            // 
            lblJogadorVelocidade.AutoSize = true;
            lblJogadorVelocidade.Location = new Point(168, 158);
            lblJogadorVelocidade.Margin = new Padding(1, 0, 1, 0);
            lblJogadorVelocidade.Name = "lblJogadorVelocidade";
            lblJogadorVelocidade.Size = new Size(22, 15);
            lblJogadorVelocidade.TabIndex = 1;
            lblJogadorVelocidade.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 158);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Velocidade Maxima:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblCartasComputador);
            groupBox2.Controls.Add(lblComputadorVelocidade);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(22, 27);
            groupBox2.Margin = new Padding(1, 1, 1, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(1, 1, 1, 1);
            groupBox2.Size = new Size(278, 395);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Computador";
            // 
            // lblCartasComputador
            // 
            lblCartasComputador.AutoSize = true;
            lblCartasComputador.Location = new Point(24, 40);
            lblCartasComputador.Margin = new Padding(1, 0, 1, 0);
            lblCartasComputador.Name = "lblCartasComputador";
            lblCartasComputador.Size = new Size(0, 15);
            lblCartasComputador.TabIndex = 4;
            // 
            // lblComputadorVelocidade
            // 
            lblComputadorVelocidade.AutoSize = true;
            lblComputadorVelocidade.Location = new Point(159, 161);
            lblComputadorVelocidade.Margin = new Padding(1, 0, 1, 0);
            lblComputadorVelocidade.Name = "lblComputadorVelocidade";
            lblComputadorVelocidade.Size = new Size(22, 15);
            lblComputadorVelocidade.TabIndex = 3;
            lblComputadorVelocidade.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 161);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 2;
            label3.Text = "Velocidade Maxima:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 356);
            Controls.Add(splitContainer1);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label lblJogadorVelocidade;
        private Label lblComputadorVelocidade;
        private Label label3;
        private Label lblCartasJogador;
        private Label lblCartasComputador;
    }
}