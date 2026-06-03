using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;



namespace CPE262PRELIM_MILOS
{

    public partial class Orderform : Form
    {
        decimal total = 0;
        public Orderform()
        {

            InitializeComponent();
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Renderer = new FlatMenuRenderer();
            menuStrip1.ForeColor = Color.White;
            fileToolStripMenuItem.DropDown.BackColor = Color.FromArgb(26, 10, 0);
            fileToolStripMenuItem.DropDown.ForeColor = Color.White;
            tabControl1.TabPages[0].Text = "Meals";
            tabControl1.TabPages[1].Text = "Drinks";
            tabControl1.TabPages[2].Text = "Desserts";




        }


        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel current order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listBoxCart.Items.Clear();
                total = 0;
                UpdateTotal();
            }
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





        private void btnChickenjoy_Click(object sender, EventArgs e)
        {
            AddItem("Chickenjoy Solo", 95);
        }

        private void btnSpaghetti_Click(object sender, EventArgs e)
        {
            AddItem("Jolly Spaghetti", 60);
        }
        private void btncokereg_Click(object sender, EventArgs e)
        {
            AddItem("Coke Regular", 40);
        }
        private void btnicedtea_Click(object sender, EventArgs e)
        {
            AddItem("Iced Tea", 30);
        }
        private void btnpineapple_Click(object sender, EventArgs e)
        {
            AddItem("Pineapple Juice", 40);
        }
        private void btnsundae_Click(object sender, EventArgs e)
        {
            AddItem("Sundae", 50);
        }
        private void btndessert2_Click(object sender, EventArgs e)
        {
            AddItem("Ice Cream", 40);
        }
        private void btndessert3_Click(object sender, EventArgs e)
        {
            AddItem("Halo Halo", 75);
        }

        private void btnBurgerSteak_Click(object sender, EventArgs e)
        {
            AddItem("Burger Steak", 75);
        }

        // 🧮 Add to cart function
        private void AddItem(string name, decimal price)
        {
            listBoxCart.Items.Add($"{name} - ₱{price}");
            total += price;
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            lblTotal.Text = $"Total: ₱{total}";
        }
        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedItem != null)
            {
                string item = listBoxCart.SelectedItem.ToString();
                decimal price = GetPriceFromItem(item);
                total -= price;
                listBoxCart.Items.Remove(listBoxCart.SelectedItem);
                UpdateTotal();
            }
        }

        // 🧹 Context Menu — Clear Cart
        private void clearCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxCart.Items.Clear();
            total = 0;
            UpdateTotal();
        }

        // Helper: Extract price from “Item - ₱price”
        private decimal GetPriceFromItem(string itemText)
        {
            try
            {
                string priceText = itemText.Split('₱').Last();
                return Convert.ToDecimal(priceText);
            }
            catch
            {
                return 0;
            }
        }

        // 💳 Checkout Button
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (listBoxCart.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"Thank you for ordering!\n\nYour total is ₱{total}.", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBoxCart.Items.Clear();
            total = 0;
            UpdateTotal();
        }
        private void listBoxCart_Click(object sender, EventArgs e)
        {
            // Intentionally empty
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            about ab = new about();
            ab.Owner = this;
            this.Hide();
            ab.Show();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}














































public class FlatMenuRenderer : ToolStripProfessionalRenderer
{
    public FlatMenuRenderer() : base(new FlatMenuColorTable()) { }

    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        // When hovered or selected
        if (e.Item.Selected)
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(26, 10, 0)), new Rectangle(Point.Empty, e.Item.Size));
        else
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(26, 10, 0)), new Rectangle(Point.Empty, e.Item.Size));
    }

    protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
    {
        // No borders
    }

    protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
    {
        // No icon margin background
    }
}

public class FlatMenuColorTable : ProfessionalColorTable
{
    public override Color MenuItemSelected => Color.FromArgb(180, 0, 0);
    public override Color MenuItemBorder => Color.Transparent;
    public override Color MenuBorder => Color.Transparent;
    public override Color ToolStripDropDownBackground => Color.FromArgb(180, 0, 0);
}
