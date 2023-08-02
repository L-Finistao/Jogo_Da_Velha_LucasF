namespace Jogo_Da_Velha_LucasF
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
            Bt09 = new Button();
            Bt01 = new Button();
            Bt04 = new Button();
            Bt07 = new Button();
            Bt05 = new Button();
            Bt02 = new Button();
            Bt03 = new Button();
            Bt08 = new Button();
            Bt06 = new Button();
            pictureBox1 = new PictureBox();
            RestartButton = new Button();
            button10 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Bt09
            // 
            Bt09.BackColor = SystemColors.Window;
            Bt09.Location = new Point(238, 249);
            Bt09.Name = "Bt09";
            Bt09.Size = new Size(67, 59);
            Bt09.TabIndex = 0;
            Bt09.UseVisualStyleBackColor = false;
            Bt09.Click += button_Click;
            Bt09.MouseLeave += verificar;
            // 
            // Bt01
            // 
            Bt01.BackColor = SystemColors.Window;
            Bt01.Location = new Point(92, 119);
            Bt01.Name = "Bt01";
            Bt01.Size = new Size(67, 59);
            Bt01.TabIndex = 1;
            Bt01.UseVisualStyleBackColor = false;
            Bt01.Click += button_Click;
            Bt01.MouseEnter += verificar;
            // 
            // Bt04
            // 
            Bt04.BackColor = SystemColors.Window;
            Bt04.Location = new Point(92, 184);
            Bt04.Name = "Bt04";
            Bt04.Size = new Size(67, 59);
            Bt04.TabIndex = 2;
            Bt04.UseVisualStyleBackColor = false;
            Bt04.Click += button_Click;
            Bt04.MouseLeave += verificar;
            // 
            // Bt07
            // 
            Bt07.BackColor = SystemColors.Window;
            Bt07.Location = new Point(92, 249);
            Bt07.Name = "Bt07";
            Bt07.Size = new Size(67, 59);
            Bt07.TabIndex = 3;
            Bt07.UseVisualStyleBackColor = false;
            Bt07.Click += button_Click;
            Bt07.MouseLeave += verificar;
            // 
            // Bt05
            // 
            Bt05.BackColor = SystemColors.Window;
            Bt05.Location = new Point(165, 184);
            Bt05.Name = "Bt05";
            Bt05.Size = new Size(67, 59);
            Bt05.TabIndex = 4;
            Bt05.UseVisualStyleBackColor = false;
            Bt05.Click += button_Click;
            Bt05.MouseLeave += verificar;
            // 
            // Bt02
            // 
            Bt02.BackColor = SystemColors.Window;
            Bt02.Location = new Point(165, 119);
            Bt02.Name = "Bt02";
            Bt02.Size = new Size(67, 59);
            Bt02.TabIndex = 5;
            Bt02.UseVisualStyleBackColor = false;
            Bt02.Click += button_Click;
            Bt02.MouseLeave += verificar;
            // 
            // Bt03
            // 
            Bt03.BackColor = SystemColors.Window;
            Bt03.Location = new Point(238, 120);
            Bt03.Name = "Bt03";
            Bt03.Size = new Size(67, 59);
            Bt03.TabIndex = 6;
            Bt03.UseVisualStyleBackColor = false;
            Bt03.Click += button_Click;
            Bt03.MouseLeave += verificar;
            // 
            // Bt08
            // 
            Bt08.BackColor = SystemColors.Window;
            Bt08.Location = new Point(165, 249);
            Bt08.Name = "Bt08";
            Bt08.Size = new Size(67, 59);
            Bt08.TabIndex = 7;
            Bt08.UseVisualStyleBackColor = false;
            Bt08.Click += button_Click;
            Bt08.MouseLeave += verificar;
            // 
            // Bt06
            // 
            Bt06.BackColor = SystemColors.Window;
            Bt06.Location = new Point(238, 184);
            Bt06.Name = "Bt06";
            Bt06.Size = new Size(67, 59);
            Bt06.TabIndex = 8;
            Bt06.UseVisualStyleBackColor = false;
            Bt06.Click += button_Click;
            Bt06.MouseLeave += verificar;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(92, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 189);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // RestartButton
            // 
            RestartButton.BackColor = SystemColors.ActiveCaption;
            RestartButton.ForeColor = Color.MidnightBlue;
            RestartButton.Location = new Point(12, 347);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(124, 41);
            RestartButton.TabIndex = 10;
            RestartButton.Text = "Reiniciar";
            RestartButton.UseVisualStyleBackColor = false;
            RestartButton.Click += Restart_Game;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ActiveCaption;
            button10.ForeColor = Color.MidnightBlue;
            button10.Location = new Point(264, 347);
            button10.Name = "button10";
            button10.Size = new Size(124, 41);
            button10.TabIndex = 12;
            button10.Text = "SAIR";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonFace;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(98, 69);
            label1.Name = "label1";
            label1.Size = new Size(207, 48);
            label1.TabIndex = 13;
            label1.Text = "teste";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_989794366_170667a;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(400, 400);
            Controls.Add(label1);
            Controls.Add(button10);
            Controls.Add(RestartButton);
            Controls.Add(Bt06);
            Controls.Add(Bt08);
            Controls.Add(Bt03);
            Controls.Add(Bt02);
            Controls.Add(Bt05);
            Controls.Add(Bt07);
            Controls.Add(Bt04);
            Controls.Add(Bt01);
            Controls.Add(Bt09);
            Controls.Add(pictureBox1);
            ForeColor = Color.Coral;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Bt09;
        private Button Bt01;
        private Button Bt04;
        private Button Bt07;
        private Button Bt05;
        private Button Bt02;
        private Button Bt03;
        private Button Bt08;
        private Button Bt06;
        private PictureBox pictureBox1;
        private Button RestartButton;
        private Button button10;
        private Label label1;
    }
}