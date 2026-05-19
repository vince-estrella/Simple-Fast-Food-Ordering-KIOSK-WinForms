namespace CPE262PRELIM_MILOS
{
    partial class about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Firebrick;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(106, 13);
            label1.Name = "label1";
            label1.Size = new Size(272, 25);
            label1.TabIndex = 0;
            label1.Text = "Restaurant Kiosk System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 12F);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(168, 51);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 1;
            label2.Text = "Version 1.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 12F);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(23, 91);
            label3.Name = "label3";
            label3.Size = new Size(427, 23);
            label3.TabIndex = 2;
            label3.Text = "Developer: Vince Gabrielle Estrella Milos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 12F);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(78, 133);
            label4.Name = "label4";
            label4.Size = new Size(311, 23);
            label4.TabIndex = 3;
            label4.Text = "Prelim Project - winForms C#";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-2, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 190);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Cooper Black", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(182, 334);
            button1.Name = "button1";
            button1.Size = new Size(121, 48);
            button1.TabIndex = 4;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnClose_Click;
            // 
            // about
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(460, 519);
            Controls.Add(button1);
            Controls.Add(panel1);
            ForeColor = Color.Cornsilk;
            Name = "about";
            Text = "about";
            Load += about_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Button button1;
    }
}