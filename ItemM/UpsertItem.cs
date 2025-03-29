using System;
using System.Windows.Forms;
using ItemM.Models;
using ItemM.Repository;

namespace ItemM
{
    public partial class UpsertItem : Form
    {
        private int itemId = 0;

        public UpsertItem()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.DialogResult = DialogResult.Cancel;
        }

        private void UpsertItem_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void EditItem(Item item)
        {
            this.Text = "Edit Item";

            this.tbItemName.Text = item.ItemName;
            this.tbItemDescription.Text = item.ItemDescription;
            this.itemId = item.ItemID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item
                {
                    ItemID = this.itemId,
                    ItemName = this.tbItemName.Text,
                    ItemDescription = this.tbItemDescription.Text
                };

                var repo = new ItemRepository();
                if (item.ItemID == 0)
                {
                    repo.CreateItem(item);
                }
                else
                {
                    repo.UpdateItem(item);
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
