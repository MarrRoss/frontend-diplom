namespace license_desktop.Presentation
{
    partial class MainForm
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
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            RegisterName = new ColumnHeader();
            Comment = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { FirstName, LastName, RegisterName, Comment });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 12);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.ShowItemToolTips = true;
            listView1.Size = new Size(704, 426);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // FirstName
            // 
            FirstName.Tag = "FirstName";
            FirstName.Text = "FirstName";
            FirstName.Width = 180;
            // 
            // LastName
            // 
            LastName.Tag = "LastName";
            LastName.Text = "LastName";
            LastName.Width = 180;
            // 
            // RegisterName
            // 
            RegisterName.Tag = "RegisterName";
            RegisterName.Text = "RegisterName";
            RegisterName.Width = 120;
            // 
            // Comment
            // 
            Comment.Tag = "Comment";
            Comment.Text = "Comment";
            Comment.Width = 220;
            // 
            // button1
            // 
            button1.Location = new Point(722, 12);
            button1.Name = "button1";
            button1.Size = new Size(136, 23);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(722, 41);
            button2.Name = "button2";
            button2.Size = new Size(136, 23);
            button2.TabIndex = 2;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 448);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader RegisterName;
        private ColumnHeader Comment;
    }
}