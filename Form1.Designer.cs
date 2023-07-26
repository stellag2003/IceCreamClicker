namespace Jogo2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox7 = new PictureBox();
            label17 = new Label();
            pictureBox3 = new PictureBox();
            label16 = new Label();
            button5 = new Button();
            pictureBox6 = new PictureBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            pictureBox5 = new PictureBox();
            button4 = new Button();
            label10 = new Label();
            label9 = new Label();
            imgUrso = new PictureBox();
            button3 = new Button();
            label8 = new Label();
            label7 = new Label();
            imgPinguim = new PictureBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUrso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPinguim).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightBlue;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += OI;
            pictureBox1.MouseUp += OI2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(226, 23);
            label1.TabIndex = 2;
            label1.Text = "Número de sorvetes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 58);
            label2.Name = "label2";
            label2.Size = new Size(19, 21);
            label2.TabIndex = 3;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(50, 98);
            label3.Name = "label3";
            label3.Size = new Size(162, 20);
            label3.TabIndex = 4;
            label3.Text = "Sorvetes por segundo";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(122, 133);
            label4.Name = "label4";
            label4.Size = new Size(15, 17);
            label4.TabIndex = 5;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(50, 11);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 6;
            label5.Text = "pinguim";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(70, 35);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 7;
            label6.Text = "10";
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(46, 53);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "COMPRAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-289, -20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1436, 648);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(499, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 191);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(imgUrso);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(imgPinguim);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(499, 256);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 343);
            panel2.TabIndex = 11;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 90);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(260, 90);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(0, 326);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(260, 90);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 14;
            pictureBox7.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlDark;
            label17.Location = new Point(17, 327);
            label17.Name = "label17";
            label17.Size = new Size(14, 15);
            label17.TabIndex = 27;
            label17.Text = "0";
            label17.Click += label17_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-3, 207);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(260, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(60, 368);
            label16.Name = "label16";
            label16.Size = new Size(35, 15);
            label16.TabIndex = 26;
            label16.Text = "1000";
            label16.Click += label16_Click;
            // 
            // button5
            // 
            button5.ForeColor = SystemColors.Highlight;
            button5.Location = new Point(46, 390);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 25;
            button5.Text = "COMPRAR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(165, 337);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(73, 79);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ControlDark;
            label15.Location = new Point(50, 327);
            label15.Name = "label15";
            label15.Size = new Size(64, 15);
            label15.TabIndex = 23;
            label15.Text = "sorveteria";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ControlDark;
            label14.Location = new Point(11, 220);
            label14.Name = "label14";
            label14.Size = new Size(14, 15);
            label14.TabIndex = 22;
            label14.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlDark;
            label13.Location = new Point(11, 105);
            label13.Name = "label13";
            label13.Size = new Size(14, 15);
            label13.TabIndex = 21;
            label13.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDark;
            label12.Location = new Point(11, 16);
            label12.Name = "label12";
            label12.Size = new Size(14, 15);
            label12.TabIndex = 20;
            label12.Text = "0";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(168, 234);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 61);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.MenuHighlight;
            button4.Location = new Point(46, 274);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 14;
            button4.Text = "COMPRAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(70, 256);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 19;
            label10.Text = "600";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonShadow;
            label9.Location = new Point(30, 220);
            label9.Name = "label9";
            label9.Size = new Size(116, 15);
            label9.TabIndex = 18;
            label9.Text = "carrinho de sorvete";
            // 
            // imgUrso
            // 
            imgUrso.Image = (Image)resources.GetObject("imgUrso.Image");
            imgUrso.Location = new Point(168, 103);
            imgUrso.Name = "imgUrso";
            imgUrso.Size = new Size(73, 69);
            imgUrso.SizeMode = PictureBoxSizeMode.Zoom;
            imgUrso.TabIndex = 17;
            imgUrso.TabStop = false;
            imgUrso.Click += pictureBox3_Click;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.MenuHighlight;
            button3.Location = new Point(46, 157);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 16;
            button3.Text = "COMPRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(70, 139);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 15;
            label8.Text = "50";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonShadow;
            label7.Location = new Point(50, 103);
            label7.Name = "label7";
            label7.Size = new Size(71, 17);
            label7.TabIndex = 13;
            label7.Text = "urso polar";
            label7.Click += label7_Click;
            // 
            // imgPinguim
            // 
            imgPinguim.BackColor = SystemColors.GradientInactiveCaption;
            imgPinguim.Image = (Image)resources.GetObject("imgPinguim.Image");
            imgPinguim.Location = new Point(165, 16);
            imgPinguim.Name = "imgPinguim";
            imgPinguim.Size = new Size(73, 65);
            imgPinguim.SizeMode = PictureBoxSizeMode.Zoom;
            imgPinguim.TabIndex = 12;
            imgPinguim.TabStop = false;
            imgPinguim.Click += imgPinguim_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.GradientInactiveCaption;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(597, 238);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 12;
            label11.Text = "MELHORIAS";
            label11.Click += label11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 623);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUrso).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPinguim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox imgPinguim;
        private Label label8;
        private Label label7;
        private PictureBox imgUrso;
        private Button button3;
        private PictureBox pictureBox3;
        private Button button4;
        private Label label10;
        private Label label9;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label11;
        private Label label14;
        private Label label13;
        private Label label12;
        private Button button5;
        private PictureBox pictureBox6;
        private Label label15;
        private Label label17;
        private Label label16;
        private PictureBox pictureBox7;
    }
}