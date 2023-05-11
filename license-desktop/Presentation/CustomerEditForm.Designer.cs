namespace license_desktop.Presentation
{
    partial class CustomerEditForm
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
            PostCode = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            Street = new ComboBox();
            label14 = new Label();
            City = new ComboBox();
            Country = new ComboBox();
            Phone = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            label10 = new Label();
            Company = new ComboBox();
            label9 = new Label();
            RName = new TextBox();
            label7 = new Label();
            LName = new TextBox();
            FName = new TextBox();
            button1 = new Button();
            label1 = new Label();
            State = new ComboBox();
            SuspendLayout();
            // 
            // PostCode
            // 
            PostCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PostCode.DisplayMember = "Name";
            PostCode.DropDownStyle = ComboBoxStyle.DropDownList;
            PostCode.Location = new Point(225, 282);
            PostCode.Name = "PostCode";
            PostCode.Size = new Size(490, 23);
            PostCode.TabIndex = 50;
            PostCode.ValueMember = "Id";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 224);
            label11.Name = "label11";
            label11.Padding = new Padding(6);
            label11.Size = new Size(52, 27);
            label11.TabIndex = 44;
            label11.Text = "Город";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 278);
            label12.Name = "label12";
            label12.Padding = new Padding(6);
            label12.Size = new Size(59, 27);
            label12.TabIndex = 49;
            label12.Text = "Индекс";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 251);
            label13.Name = "label13";
            label13.Padding = new Padding(6);
            label13.Size = new Size(53, 27);
            label13.TabIndex = 45;
            label13.Text = "Улица";
            // 
            // Street
            // 
            Street.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Street.DisplayMember = "Name";
            Street.DropDownStyle = ComboBoxStyle.DropDownList;
            Street.Location = new Point(225, 255);
            Street.Name = "Street";
            Street.Size = new Size(490, 23);
            Street.TabIndex = 48;
            Street.ValueMember = "Id";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 165);
            label14.Name = "label14";
            label14.Padding = new Padding(6);
            label14.Size = new Size(58, 27);
            label14.TabIndex = 43;
            label14.Text = "Страна";
            // 
            // City
            // 
            City.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            City.DisplayMember = "Name";
            City.DropDownStyle = ComboBoxStyle.DropDownList;
            City.Location = new Point(225, 228);
            City.Name = "City";
            City.Size = new Size(490, 23);
            City.TabIndex = 47;
            City.ValueMember = "Id";
            // 
            // Country
            // 
            Country.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Country.DisplayMember = "Name";
            Country.DropDownStyle = ComboBoxStyle.DropDownList;
            Country.Location = new Point(225, 169);
            Country.Name = "Country";
            Country.Size = new Size(490, 23);
            Country.TabIndex = 46;
            Country.ValueMember = "Id";
            // 
            // Phone
            // 
            Phone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Phone.DisplayMember = "Name";
            Phone.DropDownStyle = ComboBoxStyle.DropDownList;
            Phone.Location = new Point(225, 121);
            Phone.Name = "Phone";
            Phone.RightToLeft = RightToLeft.No;
            Phone.Size = new Size(490, 23);
            Phone.TabIndex = 42;
            Phone.ValueMember = "Id";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 63);
            label8.Name = "label8";
            label8.Padding = new Padding(6);
            label8.Size = new Size(158, 27);
            label8.TabIndex = 35;
            label8.Text = "Регистрационный номер";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 117);
            label6.Name = "label6";
            label6.Padding = new Padding(6);
            label6.Size = new Size(67, 27);
            label6.TabIndex = 41;
            label6.Text = "Телефон";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 90);
            label10.Name = "label10";
            label10.Padding = new Padding(6);
            label10.Size = new Size(75, 27);
            label10.TabIndex = 36;
            label10.Text = "Компания";
            // 
            // Company
            // 
            Company.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Company.DisplayMember = "Name";
            Company.DropDownStyle = ComboBoxStyle.DropDownList;
            Company.Location = new Point(225, 94);
            Company.Name = "Company";
            Company.Size = new Size(490, 23);
            Company.TabIndex = 40;
            Company.ValueMember = "Id";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 36);
            label9.Name = "label9";
            label9.Padding = new Padding(6);
            label9.Size = new Size(70, 27);
            label9.TabIndex = 34;
            label9.Text = "Фамилия";
            // 
            // RName
            // 
            RName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            RName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            RName.Location = new Point(225, 67);
            RName.Name = "RName";
            RName.Size = new Size(490, 23);
            RName.TabIndex = 39;
            RName.Text = "123";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Padding = new Padding(6);
            label7.Size = new Size(43, 27);
            label7.TabIndex = 33;
            label7.Text = "Имя";
            // 
            // LName
            // 
            LName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            LName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            LName.Location = new Point(225, 40);
            LName.Name = "LName";
            LName.Size = new Size(490, 23);
            LName.TabIndex = 38;
            LName.Text = "123";
            // 
            // FName
            // 
            FName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            FName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            FName.Location = new Point(225, 13);
            FName.Name = "FName";
            FName.Size = new Size(490, 23);
            FName.TabIndex = 37;
            FName.Text = "123";
            // 
            // button1
            // 
            button1.Location = new Point(499, 311);
            button1.Name = "button1";
            button1.Size = new Size(216, 23);
            button1.TabIndex = 51;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 194);
            label1.Name = "label1";
            label1.Padding = new Padding(6);
            label1.Size = new Size(65, 27);
            label1.TabIndex = 52;
            label1.Text = "Область";
            // 
            // State
            // 
            State.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            State.DisplayMember = "Name";
            State.DropDownStyle = ComboBoxStyle.DropDownList;
            State.Location = new Point(225, 198);
            State.Name = "State";
            State.Size = new Size(490, 23);
            State.TabIndex = 53;
            State.ValueMember = "Id";
            // 
            // CustomerEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 342);
            Controls.Add(label1);
            Controls.Add(State);
            Controls.Add(button1);
            Controls.Add(PostCode);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(Street);
            Controls.Add(label14);
            Controls.Add(City);
            Controls.Add(Country);
            Controls.Add(Phone);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(Company);
            Controls.Add(label9);
            Controls.Add(RName);
            Controls.Add(label7);
            Controls.Add(LName);
            Controls.Add(FName);
            Name = "CustomerEditForm";
            Text = "CustomerEditForm";
            Load += CustomerEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox PostCode;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox Street;
        private Label label14;
        private ComboBox City;
        private ComboBox Country;
        private ComboBox Phone;
        private Label label8;
        private Label label6;
        private Label label10;
        private ComboBox Company;
        private Label label9;
        private TextBox RName;
        private Label label7;
        private TextBox LName;
        private TextBox FName;
        private Button button1;
        private Label label1;
        private ComboBox State;
    }
}