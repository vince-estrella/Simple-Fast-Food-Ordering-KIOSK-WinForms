namespace CPE262PRELIM_MILOS
{
    partial class Orderform
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orderform));
            panel1 = new Panel();
            lblTotal = new Label();
            button10 = new Button();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            label11 = new Label();
            listBoxCart = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            removeItemToolStripMenuItem = new ToolStripMenuItem();
            clearCartToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel6 = new Panel();
            button3 = new Button();
            label3 = new Label();
            panel5 = new Panel();
            button2 = new Button();
            label2 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            label1 = new Label();
            tabPage3 = new TabPage();
            button9 = new Button();
            label8 = new Label();
            panel11 = new Panel();
            button8 = new Button();
            label9 = new Label();
            panel10 = new Panel();
            button7 = new Button();
            label7 = new Label();
            tabPage2 = new TabPage();
            panel9 = new Panel();
            label10 = new Label();
            label4 = new Label();
            button5 = new Button();
            panel8 = new Panel();
            label5 = new Label();
            button4 = new Button();
            panel7 = new Panel();
            label6 = new Label();
            button6 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            backToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            tabPage3.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            tabPage2.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(button10);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 622);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 43);
            panel1.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.Control;
            lblTotal.Location = new Point(12, 12);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(74, 23);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: P0";
            // 
            // button10
            // 
            button10.BackColor = Color.Firebrick;
            button10.ForeColor = Color.Snow;
            button10.Location = new Point(287, 6);
            button10.Name = "button10";
            button10.Size = new Size(127, 29);
            button10.TabIndex = 7;
            button10.Text = "CHECK OUT";
            button10.UseVisualStyleBackColor = false;
            button10.Click += btnCheckout_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(tabControl1);
            panel3.Controls.Add(menuStrip1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(426, 622);
            panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(26, 10, 0);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(listBoxCart);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(0, 469);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 153);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order Summary";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(85, 33);
            label11.Name = "label11";
            label11.Size = new Size(244, 23);
            label11.TabIndex = 8;
            label11.Text = "right click on items to edit cart";
            // 
            // listBoxCart
            // 
            listBoxCart.BackColor = Color.FromArgb(26, 10, 0);
            listBoxCart.ContextMenuStrip = contextMenuStrip1;
            listBoxCart.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxCart.ForeColor = SystemColors.Window;
            listBoxCart.FormattingEnabled = true;
            listBoxCart.Location = new Point(24, 59);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.RightToLeft = RightToLeft.No;
            listBoxCart.Size = new Size(377, 73);
            listBoxCart.TabIndex = 3;
            listBoxCart.Click += listBoxCart_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { removeItemToolStripMenuItem, clearCartToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(163, 52);
            // 
            // removeItemToolStripMenuItem
            // 
            removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            removeItemToolStripMenuItem.Size = new Size(162, 24);
            removeItemToolStripMenuItem.Text = "remove item";
            removeItemToolStripMenuItem.Click += removeItemToolStripMenuItem_Click;
            // 
            // clearCartToolStripMenuItem
            // 
            clearCartToolStripMenuItem.Name = "clearCartToolStripMenuItem";
            clearCartToolStripMenuItem.Size = new Size(162, 24);
            clearCartToolStripMenuItem.Text = "clear cart";
            clearCartToolStripMenuItem.Click += clearCartToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(33, 120);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(357, 307);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(26, 10, 0);
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel4);
            tabPage1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(349, 274);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "tabPage1";
            // 
            // panel6
            // 
            panel6.Controls.Add(button3);
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(3, 151);
            panel6.Name = "panel6";
            panel6.Size = new Size(343, 74);
            panel6.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            button3.ForeColor = Color.Snow;
            button3.Location = new Point(244, 22);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Add to cart";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnBurgerSteak_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(14, 24);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 2;
            label3.Text = "Burger Steak - P75";
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(3, 77);
            panel5.Name = "panel5";
            panel5.Size = new Size(343, 74);
            panel5.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            button2.ForeColor = Color.Snow;
            button2.Location = new Point(244, 24);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Add to cart";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnSpaghetti_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(14, 26);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 1;
            label2.Text = "Spaghetti - P60";
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(343, 74);
            panel4.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(244, 23);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Add to cart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnChickenjoy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(177, 23);
            label1.TabIndex = 0;
            label1.Text = "Chickenjoy Solo - P95";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(26, 10, 0);
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(panel11);
            tabPage3.Controls.Add(panel10);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(349, 274);
            tabPage3.TabIndex = 5;
            tabPage3.Text = "tabPage3";
            // 
            // button9
            // 
            button9.BackColor = Color.Firebrick;
            button9.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            button9.ForeColor = Color.Snow;
            button9.Location = new Point(249, 173);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 13;
            button9.Text = "Add to cart";
            button9.UseVisualStyleBackColor = false;
            button9.Click += btnicedtea_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.ForeColor = Color.Yellow;
            label8.Location = new Point(15, 175);
            label8.Name = "label8";
            label8.Size = new Size(117, 23);
            label8.TabIndex = 12;
            label8.Text = "Iced Tea - P30";
            // 
            // panel11
            // 
            panel11.Controls.Add(button8);
            panel11.Controls.Add(label9);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(3, 77);
            panel11.Name = "panel11";
            panel11.Size = new Size(343, 74);
            panel11.TabIndex = 11;
            // 
            // button8
            // 
            button8.BackColor = Color.Firebrick;
            button8.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            button8.ForeColor = Color.Snow;
            button8.Location = new Point(244, 25);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 14;
            button8.Text = "Add to cart";
            button8.UseVisualStyleBackColor = false;
            button8.Click += btncokereg_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.ForeColor = Color.Yellow;
            label9.Location = new Point(12, 27);
            label9.Name = "label9";
            label9.Size = new Size(130, 23);
            label9.TabIndex = 8;
            label9.Text = "Coke Reg - P40";
            // 
            // panel10
            // 
            panel10.Controls.Add(button7);
            panel10.Controls.Add(label7);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(343, 74);
            panel10.TabIndex = 10;
            // 
            // button7
            // 
            button7.BackColor = Color.Firebrick;
            button7.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            button7.ForeColor = Color.Snow;
            button7.Location = new Point(244, 26);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 15;
            button7.Text = "Add to cart";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnpineapple_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(12, 26);
            label7.Name = "label7";
            label7.Size = new Size(165, 23);
            label7.TabIndex = 6;
            label7.Text = "Pinapple Juice - P40";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(26, 10, 0);
            tabPage2.Controls.Add(panel9);
            tabPage2.Controls.Add(panel8);
            tabPage2.Controls.Add(panel7);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(349, 274);
            tabPage2.TabIndex = 4;
            tabPage2.Text = "tabPage2";
            // 
            // panel9
            // 
            panel9.Controls.Add(label10);
            panel9.Controls.Add(label4);
            panel9.Controls.Add(button5);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(3, 77);
            panel9.Name = "panel9";
            panel9.Size = new Size(343, 74);
            panel9.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(20, -49);
            label10.Name = "label10";
            label10.Size = new Size(132, 23);
            label10.TabIndex = 7;
            label10.Text = "Halo Halo - P75";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(20, 26);
            label4.Name = "label4";
            label4.Size = new Size(112, 23);
            label4.TabIndex = 4;
            label4.Text = "Sundae - P50";
            // 
            // button5
            // 
            button5.BackColor = Color.Firebrick;
            button5.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            button5.ForeColor = Color.Snow;
            button5.Location = new Point(246, 26);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 8;
            button5.Text = "Add to cart";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnsundae_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(label5);
            panel8.Controls.Add(button4);
            panel8.Location = new Point(3, 151);
            panel8.Name = "panel8";
            panel8.Size = new Size(343, 74);
            panel8.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(20, 28);
            label5.Name = "label5";
            label5.Size = new Size(133, 23);
            label5.TabIndex = 5;
            label5.Text = "Ice Cream - P40";
            // 
            // button4
            // 
            button4.BackColor = Color.Firebrick;
            button4.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            button4.ForeColor = Color.Snow;
            button4.Location = new Point(246, 28);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 9;
            button4.Text = "Add to cart";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btndessert2_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(label6);
            panel7.Controls.Add(button6);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(343, 74);
            panel7.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(20, 25);
            label6.Name = "label6";
            label6.Size = new Size(132, 23);
            label6.TabIndex = 7;
            label6.Text = "Halo Halo - P75";
            // 
            // button6
            // 
            button6.BackColor = Color.Firebrick;
            button6.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            button6.ForeColor = Color.Snow;
            button6.Location = new Point(249, 23);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 6;
            button6.Text = "Add to cart";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btndessert3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(26, 10, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(426, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.AutoToolTip = true;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem, backToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            fileToolStripMenuItem.ForeColor = SystemColors.Window;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(50, 27);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.FromArgb(26, 10, 0);
            exitToolStripMenuItem.ForeColor = SystemColors.Window;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(130, 28);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.BackColor = Color.FromArgb(26, 10, 0);
            backToolStripMenuItem.ForeColor = Color.White;
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(130, 28);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            helpToolStripMenuItem.ForeColor = Color.White;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(60, 27);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.BackColor = Color.FromArgb(26, 10, 0);
            aboutToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            aboutToolStripMenuItem.ForeColor = SystemColors.Window;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(141, 28);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Orderform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 665);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Orderform";
            Text = "Orderform";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TabControl tabControl1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Panel panel6;
        private Label label3;
        private Panel panel5;
        private Label label2;
        private Panel panel4;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel7;
        private Panel panel8;
        private Label label4;
        private Label label5;
        private Button button4;
        private Label label6;
        private Button button5;
        private Button button6;
        private Panel panel9;
        private Label label9;
        private Label label7;
        private Panel panel11;
        private Panel panel10;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label8;
        private Button button10;
        private GroupBox groupBox1;
        private Label lblTotal;
        private ListBox listBoxCart;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem removeItemToolStripMenuItem;
        private ToolStripMenuItem clearCartToolStripMenuItem;
        private Label label10;
        private Label label11;
    }
}