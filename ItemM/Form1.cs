using System.Data;
using ItemM.Repository;

namespace ItemM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                ReadItems();
            }
            else
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpsertItem form = new UpsertItem();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadItems();
            }
        }

        private void ReadItems()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ItemID");
            dataTable.Columns.Add("ItemName");
            dataTable.Columns.Add("ItemDescription");

            var repo = new ItemRepository();
            var Items = repo.GeTItems();

            foreach (var item in Items)
            {
                DataRow row = dataTable.NewRow();
                row["ItemID"] = item.ItemID;
                row["ItemName"] = item.ItemName;
                row["ItemDescription"] = item.ItemDescription;
                dataTable.Rows.Add(row);
            }
            this.ItemTable.DataSource = dataTable;
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

            var val = this.ItemTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int itemId = int.Parse(val);

            var repo = new ItemRepository();
            var item = repo.GetItem(itemId);

            if (item == null) return;
            UpsertItem form = new UpsertItem();
            form.EditItem(item);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadItems();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var val = this.ItemTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;
            int itemId = int.Parse(val);

            DialogResult dialogResult= MessageBox.Show("are you sure you want to delete?", "Delete Item",MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) { 
                return;
            }

            var repo = new ItemRepository();
            repo.DeleteItem(itemId);

            ReadItems();
        }
    }
}
