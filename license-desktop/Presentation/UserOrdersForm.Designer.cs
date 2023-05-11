namespace license_desktop.Presentation
{
    partial class UserOrdersForm
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
            listView1 = new ListView();
            ProductName = new ColumnHeader();
            ProductGroupName = new ColumnHeader();
            PaymentTypeName = new ColumnHeader();
            FIO = new ColumnHeader();
            Key = new ColumnHeader();
            CreatingDate = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ProductName, ProductGroupName, PaymentTypeName, FIO, Key, CreatingDate });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 12);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(918, 520);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // ProductName
            // 
            ProductName.Tag = "ProductName";
            ProductName.Text = "ProductName";
            ProductName.Width = 90;
            // 
            // ProductGroupName
            // 
            ProductGroupName.Tag = "ProductGroupName";
            ProductGroupName.Text = "ProductGroupName";
            ProductGroupName.Width = 110;
            // 
            // PaymentTypeName
            // 
            PaymentTypeName.Tag = "PaymentTypeName";
            PaymentTypeName.Text = "PaymentTypeName";
            PaymentTypeName.Width = 120;
            // 
            // FIO
            // 
            FIO.Tag = "FIO";
            FIO.Text = "FIO";
            FIO.Width = 190;
            // 
            // Key
            // 
            Key.Tag = "Key";
            Key.Text = "Key";
            Key.Width = 190;
            // 
            // CreatingDate
            // 
            CreatingDate.Tag = "CreatingDate";
            CreatingDate.Text = "CreatingDate";
            CreatingDate.Width = 80;
            // 
            // button1
            // 
            button1.Location = new Point(936, 12);
            button1.Name = "button1";
            button1.Size = new Size(32, 33);
            button1.TabIndex = 1;
            button1.Text = "O";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserOrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "UserOrdersForm";
            Text = "UserOrdersForm";
            Load += UserOrdersForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader ProductGroupName;
        private ColumnHeader PaymentTypeName;
        private ColumnHeader FIO;
        private ColumnHeader Key;
        private ColumnHeader CreatingDate;
        private ColumnHeader ProductName;
        private Button button1;
    }
}