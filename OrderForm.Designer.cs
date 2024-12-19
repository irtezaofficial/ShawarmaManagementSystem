namespace ShawarmaManagementSystem
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            TypeComboBox = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            QntyTextBox = new TextBox();
            label5 = new Label();
            NameComboBox = new ComboBox();
            PriceTextBox = new TextBox();
            label3 = new Label();
            GetTotalButton = new Button();
            TotalTextBox = new TextBox();
            label7 = new Label();
            OrderBtn = new Button();
            PaymentComboBox = new ComboBox();
            label6 = new Label();
            label8 = new Label();
            StatusTextBox = new TextBox();
            CancelButton = new Button();
            DeliveredButton = new Button();
            CompletedButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(138, 24);
            label2.Name = "label2";
            label2.Size = new Size(395, 37);
            label2.TabIndex = 16;
            label2.Text = "Shawarma Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 118);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // TypeComboBox
            // 
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeComboBox.Font = new Font("Segoe UI", 20F);
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Chicken", "Beef", "Veg" });
            TypeComboBox.Location = new Point(97, 157);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(202, 45);
            TypeComboBox.TabIndex = 27;
            TypeComboBox.SelectedIndexChanged += TypeComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(12, 163);
            label4.Name = "label4";
            label4.Size = new Size(79, 37);
            label4.TabIndex = 26;
            label4.Text = "Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 231);
            label1.Name = "label1";
            label1.Size = new Size(94, 37);
            label1.TabIndex = 28;
            label1.Text = "Name:";
            // 
            // QntyTextBox
            // 
            QntyTextBox.Font = new Font("Segoe UI", 20F);
            QntyTextBox.Location = new Point(138, 294);
            QntyTextBox.Name = "QntyTextBox";
            QntyTextBox.Size = new Size(188, 43);
            QntyTextBox.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(12, 294);
            label5.Name = "label5";
            label5.Size = new Size(125, 37);
            label5.TabIndex = 30;
            label5.Text = "Quantity:";
            // 
            // NameComboBox
            // 
            NameComboBox.Font = new Font("Segoe UI", 20F);
            NameComboBox.FormattingEnabled = true;
            NameComboBox.Location = new Point(112, 228);
            NameComboBox.Name = "NameComboBox";
            NameComboBox.Size = new Size(202, 45);
            NameComboBox.TabIndex = 32;
            NameComboBox.SelectedIndexChanged += NameComboBox_SelectedIndexChanged;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Enabled = false;
            PriceTextBox.Font = new Font("Segoe UI", 20F);
            PriceTextBox.Location = new Point(98, 362);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.ReadOnly = true;
            PriceTextBox.Size = new Size(188, 43);
            PriceTextBox.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(12, 362);
            label3.Name = "label3";
            label3.Size = new Size(80, 37);
            label3.TabIndex = 33;
            label3.Text = "Price:";
            // 
            // GetTotalButton
            // 
            GetTotalButton.Font = new Font("Segoe UI", 20F);
            GetTotalButton.Location = new Point(310, 436);
            GetTotalButton.Name = "GetTotalButton";
            GetTotalButton.Size = new Size(149, 45);
            GetTotalButton.TabIndex = 37;
            GetTotalButton.Text = "Get Total";
            GetTotalButton.UseVisualStyleBackColor = true;
            GetTotalButton.Click += GetTotalButton_Click;
            // 
            // TotalTextBox
            // 
            TotalTextBox.Enabled = false;
            TotalTextBox.Font = new Font("Segoe UI", 20F);
            TotalTextBox.Location = new Point(98, 436);
            TotalTextBox.Name = "TotalTextBox";
            TotalTextBox.ReadOnly = true;
            TotalTextBox.Size = new Size(188, 43);
            TotalTextBox.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(12, 439);
            label7.Name = "label7";
            label7.Size = new Size(80, 37);
            label7.TabIndex = 38;
            label7.Text = "Total:";
            // 
            // OrderBtn
            // 
            OrderBtn.Font = new Font("Segoe UI", 20F);
            OrderBtn.Location = new Point(748, 431);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(149, 45);
            OrderBtn.TabIndex = 40;
            OrderBtn.Text = "Order";
            OrderBtn.UseVisualStyleBackColor = true;
            OrderBtn.Click += OrderBtn_Click;
            // 
            // PaymentComboBox
            // 
            PaymentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PaymentComboBox.Font = new Font("Segoe UI", 20F);
            PaymentComboBox.FormattingEnabled = true;
            PaymentComboBox.Items.AddRange(new object[] { "Card", "Cash" });
            PaymentComboBox.Location = new Point(589, 157);
            PaymentComboBox.Name = "PaymentComboBox";
            PaymentComboBox.Size = new Size(202, 45);
            PaymentComboBox.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(395, 160);
            label6.Name = "label6";
            label6.Size = new Size(188, 37);
            label6.TabIndex = 41;
            label6.Text = "Payment Type:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(395, 236);
            label8.Name = "label8";
            label8.Size = new Size(169, 37);
            label8.TabIndex = 43;
            label8.Text = "Order Status:";
            // 
            // StatusTextBox
            // 
            StatusTextBox.Enabled = false;
            StatusTextBox.Font = new Font("Segoe UI", 20F);
            StatusTextBox.Location = new Point(579, 236);
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.ReadOnly = true;
            StatusTextBox.Size = new Size(188, 43);
            StatusTextBox.TabIndex = 45;
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Segoe UI", 20F);
            CancelButton.Location = new Point(384, 303);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(149, 45);
            CancelButton.TabIndex = 46;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // DeliveredButton
            // 
            DeliveredButton.Font = new Font("Segoe UI", 20F);
            DeliveredButton.Location = new Point(579, 303);
            DeliveredButton.Name = "DeliveredButton";
            DeliveredButton.Size = new Size(149, 45);
            DeliveredButton.TabIndex = 47;
            DeliveredButton.Text = "Delivered";
            DeliveredButton.UseVisualStyleBackColor = true;
            DeliveredButton.Click += DeliveredButton_Click;
            // 
            // CompletedButton
            // 
            CompletedButton.Font = new Font("Segoe UI", 20F);
            CompletedButton.Location = new Point(759, 303);
            CompletedButton.Name = "CompletedButton";
            CompletedButton.Size = new Size(149, 45);
            CompletedButton.TabIndex = 48;
            CompletedButton.Text = "Completed";
            CompletedButton.UseVisualStyleBackColor = true;
            CompletedButton.Click += CompletedButton_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 500);
            Controls.Add(CompletedButton);
            Controls.Add(DeliveredButton);
            Controls.Add(CancelButton);
            Controls.Add(StatusTextBox);
            Controls.Add(label8);
            Controls.Add(PaymentComboBox);
            Controls.Add(label6);
            Controls.Add(OrderBtn);
            Controls.Add(TotalTextBox);
            Controls.Add(label7);
            Controls.Add(GetTotalButton);
            Controls.Add(PriceTextBox);
            Controls.Add(label3);
            Controls.Add(NameComboBox);
            Controls.Add(QntyTextBox);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(TypeComboBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private ComboBox TypeComboBox;
        private Label label4;
        private Label label1;
        private TextBox QntyTextBox;
        private Label label5;
        private ComboBox NameComboBox;
        private TextBox PriceTextBox;
        private Label label3;
        private Button GetTotalButton;
        private TextBox TotalTextBox;
        private Label label7;
        private Button OrderBtn;
        private ComboBox PaymentComboBox;
        private Label label6;
        private Label label8;
        private TextBox StatusTextBox;
        private Button CancelButton;
        private Button DeliveredButton;
        private Button CompletedButton;
    }
}