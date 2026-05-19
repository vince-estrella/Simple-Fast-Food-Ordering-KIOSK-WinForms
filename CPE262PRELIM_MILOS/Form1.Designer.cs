namespace CPE262PRELIM_MILOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panelbtn = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 573);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 47);
            panel1.TabIndex = 0;
            panel1.Click += panelbtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(233, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(129, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += panelbtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += panelbtn_Click;
            // 
            // panelbtn
            // 
            panelbtn.BackColor = Color.Firebrick;
            panelbtn.Controls.Add(textBox3);
            panelbtn.Controls.Add(textBox2);
            panelbtn.Controls.Add(pictureBox1);
            panelbtn.Controls.Add(textBox1);
            panelbtn.Dock = DockStyle.Bottom;
            panelbtn.Location = new Point(0, 2);
            panelbtn.Name = "panelbtn";
            panelbtn.Size = new Size(394, 571);
            panelbtn.TabIndex = 1;
            panelbtn.Click += panelbtn_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Firebrick;
            textBox3.Location = new Point(72, 328);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 135);
            textBox3.TabIndex = 3;
            textBox3.Text = "RESTAURANT KIOSK PRELIM CPE262_MILOS";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.Click += panelbtn_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Firebrick;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Bottom;
            textBox2.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(0, 522);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(394, 49);
            textBox2.TabIndex = 2;
            textBox2.Text = "Tap anywhere to begin";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Click += panelbtn_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += panelbtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 10);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(370, 558);
            textBox1.TabIndex = 0;
            textBox1.Click += panelbtn_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(52, 14);
            label1.Name = "label1";
            label1.Size = new Size(175, 17);
            label1.TabIndex = 7;
            label1.Text = "Pay with cash or card";
            label1.Click += panelbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 620);
            Controls.Add(panelbtn);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelbtn.ResumeLayout(false);
            panelbtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelbtn;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
    }
}
