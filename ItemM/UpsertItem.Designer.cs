namespace ItemM
{
    partial class UpsertItem
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
            label1 = new Label();
            label2 = new Label();
            ItId = new Label();
            label3 = new Label();
            tbItemName = new TextBox();
            lbid = new Label();
            tbItemDescription = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 19);
            label1.Name = "label1";
            label1.Size = new Size(132, 31);
            label1.TabIndex = 0;
            label1.Text = "Create Item";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 75);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Client Id";
            // 
            // ItId
            // 
            ItId.AutoSize = true;
            ItId.Location = new Point(188, 75);
            ItId.Name = "ItId";
            ItId.Size = new Size(0, 20);
            ItId.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 114);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 3;
            label3.Text = "Item Name";
            // 
            // tbItemName
            // 
            tbItemName.Location = new Point(188, 107);
            tbItemName.Name = "tbItemName";
            tbItemName.Size = new Size(432, 27);
            tbItemName.TabIndex = 4;
            // 
            // lbid
            // 
            lbid.AutoSize = true;
            lbid.Location = new Point(31, 155);
            lbid.Name = "lbid";
            lbid.Size = new Size(119, 20);
            lbid.TabIndex = 5;
            lbid.Text = "Item Description";
            lbid.Click += label4_Click;
            // 
            // tbItemDescription
            // 
            tbItemDescription.Location = new Point(188, 155);
            tbItemDescription.Name = "tbItemDescription";
            tbItemDescription.Size = new Size(432, 27);
            tbItemDescription.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(188, 242);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 39);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(510, 242);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 39);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // UpsertItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 290);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbItemDescription);
            Controls.Add(lbid);
            Controls.Add(tbItemName);
            Controls.Add(label3);
            Controls.Add(ItId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpsertItem";
            Text = "UpsertItem";
            Load += UpsertItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label ItId;
        private Label label3;
        private TextBox tbItemName;
        private Label lbid;
        private TextBox tbItemDescription;
        private Button btnSave;
        private Button btnCancel;
    }
}