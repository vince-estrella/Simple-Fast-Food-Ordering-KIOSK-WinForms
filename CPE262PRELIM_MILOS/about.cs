using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CPE262PRELIM_MILOS
{
    public partial class about : Form
    {


        public about()
        {
            InitializeComponent();
            this.Text = "About";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            if (this.Owner != null)
                this.Owner.Show(); // show main form again
            this.Close();
        }

        private void about_Load(object sender, EventArgs e)
        {

        }
    }
}

