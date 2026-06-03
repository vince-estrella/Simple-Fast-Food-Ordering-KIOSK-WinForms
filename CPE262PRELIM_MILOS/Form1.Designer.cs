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
            panelbtn = new Panel();
            SuspendLayout();
            // 
            // panelbtn
            // 
            panelbtn.BackColor = Color.Firebrick;
            panelbtn.BackgroundImage = (Image)resources.GetObject("panelbtn.BackgroundImage");
            panelbtn.Dock = DockStyle.Bottom;
            panelbtn.Location = new Point(0, -1);
            panelbtn.Name = "panelbtn";
            panelbtn.Size = new Size(426, 685);
            panelbtn.TabIndex = 1;
            panelbtn.Click += panelbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 684);
            Controls.Add(panelbtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Panel panelbtn;
    }
}
