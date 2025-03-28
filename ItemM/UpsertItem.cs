using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            this.lbid.Text = item.ItemID.ToString();
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

