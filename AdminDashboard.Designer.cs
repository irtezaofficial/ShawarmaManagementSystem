namespace ShawarmaManagementSystem
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            pictureBox1 = new PictureBox();
            SearchTextBox = new TextBox();
            ShawarmaList = new DataGridView();
            SearchButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NameTextBox = new TextBox();
            PriceTextBox = new TextBox();
            QntyTextBox = new TextBox();
            UpdateButton = new Button();
            AddButton = new Button();
            DeleteButton = new Button();
            TypeComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShawarmaList).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 118);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Font = new Font("Segoe UI", 20F);
            SearchTextBox.Location = new Point(138, 87);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "Search";
            SearchTextBox.Size = new Size(608, 43);
            SearchTextBox.TabIndex = 9;
            // 
            // ShawarmaList
            // 
            ShawarmaList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShawarmaList.Location = new Point(12, 329);
            ShawarmaList.Name = "ShawarmaList";
            ShawarmaList.Size = new Size(776, 215);
            ShawarmaList.TabIndex = 11;
            ShawarmaList.RowHeaderMouseClick += ShawarmaList_RowHeaderMouseClick;
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Segoe UI", 20F);
            SearchButton.Location = new Point(600, 38);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(146, 43);
            SearchButton.TabIndex = 12;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 153);
            label1.Name = "label1";
            label1.Size = new Size(94, 37);
            label1.TabIndex = 13;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(138, 24);
            label2.Name = "label2";
            label2.Size = new Size(395, 37);
            label2.TabIndex = 14;
            label2.Text = "Shawarma Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(12, 208);
            label3.Name = "label3";
            label3.Size = new Size(80, 37);
            label3.TabIndex = 15;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(459, 153);
            label4.Name = "label4";
            label4.Size = new Size(79, 37);
            label4.TabIndex = 16;
            label4.Text = "Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(292, 208);
            label5.Name = "label5";
            label5.Size = new Size(125, 37);
            label5.TabIndex = 17;
            label5.Text = "Quantity:";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 20F);
            NameTextBox.Location = new Point(106, 147);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(336, 43);
            NameTextBox.TabIndex = 18;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Font = new Font("Segoe UI", 20F);
            PriceTextBox.Location = new Point(98, 208);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(188, 43);
            PriceTextBox.TabIndex = 19;
            // 
            // QntyTextBox
            // 
            QntyTextBox.Font = new Font("Segoe UI", 20F);
            QntyTextBox.Location = new Point(423, 208);
            QntyTextBox.Name = "QntyTextBox";
            QntyTextBox.Size = new Size(188, 43);
            QntyTextBox.TabIndex = 21;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Segoe UI", 20F);
            UpdateButton.Location = new Point(363, 265);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(146, 43);
            UpdateButton.TabIndex = 22;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 20F);
            AddButton.Location = new Point(138, 265);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(146, 43);
            AddButton.TabIndex = 23;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 20F);
            DeleteButton.Location = new Point(586, 265);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(146, 43);
            DeleteButton.TabIndex = 24;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // TypeComboBox
            // 
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeComboBox.Font = new Font("Segoe UI", 20F);
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Chicken", "Beef", "Veg" });
            TypeComboBox.Location = new Point(544, 147);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(202, 45);
            TypeComboBox.TabIndex = 25;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(TypeComboBox);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(UpdateButton);
            Controls.Add(QntyTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchButton);
            Controls.Add(ShawarmaList);
            Controls.Add(SearchTextBox);
            Controls.Add(pictureBox1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShawarmaList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox SearchTextBox;
        private DataGridView ShawarmaList;
        private Button SearchButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NameTextBox;
        private TextBox PriceTextBox;
        private TextBox QntyTextBox;
        private Button UpdateButton;
        private Button AddButton;
        private Button DeleteButton;
        private ComboBox TypeComboBox;
    }
}