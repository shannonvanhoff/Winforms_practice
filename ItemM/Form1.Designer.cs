namespace ItemM
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
            label1 = new Label();
            btnAdd_Click = new Button();
            ItemTable = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)ItemTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(990, 31);
            label1.TabIndex = 0;
            label1.Text = "List of Items";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // btnAdd_Click
            // 
            btnAdd_Click.Location = new Point(14, 120);
            btnAdd_Click.Margin = new Padding(3, 4, 3, 4);
            btnAdd_Click.Name = "btnAdd_Click";
            btnAdd_Click.Size = new Size(86, 31);
            btnAdd_Click.TabIndex = 1;
            btnAdd_Click.Text = "Add Item";
            btnAdd_Click.UseVisualStyleBackColor = true;
            btnAdd_Click.Click += button1_Click;
            // 
            // ItemTable
            // 
            ItemTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ItemTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemTable.Location = new Point(14, 162);
            ItemTable.Margin = new Padding(3, 4, 3, 4);
            ItemTable.MultiSelect = false;
            ItemTable.Name = "ItemTable";
            ItemTable.RowHeadersVisible = false;
            ItemTable.RowHeadersWidth = 51;
            ItemTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemTable.Size = new Size(979, 425);
            ItemTable.TabIndex = 4;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(750, 113);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(883, 113);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 600);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(ItemTable);
            Controls.Add(btnAdd_Click);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Item Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ItemTable).EndInit();
            ResumeLayout(false);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Button btnAdd_Click;
        private DataGridView ItemTable;
        private Button btnEdit;
        private Button btnDelete;
    }
}
