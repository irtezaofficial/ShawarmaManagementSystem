using System.Windows.Forms;

namespace ShawarmaManagementSystem
{
    public partial class OrderForm : Form
    {
        private List<string> Items;
        private readonly IDatabaseAdapter _dbAdapter;

        public OrderForm()
        {
            InitializeComponent();
            Items = new List<string>();
            _dbAdapter = new DatabaseAdapter();
        }

        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NameComboBox.SelectedItem != null)
            {
                QntyTextBox.Clear();
                PriceTextBox.Clear();

                string query = "Select Quantity from Shawarma where Name = '" + NameComboBox.SelectedItem.ToString() + "' ";
                string totalQuantityStr = _dbAdapter.GetInText(query);
                if (!string.IsNullOrEmpty(totalQuantityStr) && int.TryParse(totalQuantityStr, out int totalQuantity))
                {
                    QntyTextBox.Text = totalQuantity.ToString();
                }
                else
                {
                    MessageBox.Show("Failed to retrieve shawarma quantity.");
                }

                string query1 = "Select Price from Shawarma where Name = '" + NameComboBox.SelectedItem.ToString() + "' ";
                PriceTextBox.Text = _dbAdapter.GetInText(query1);
            }
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeComboBox.SelectedItem != null)
            {
                NameComboBox.SelectedItem = null;
                Items.Clear();
                NameComboBox.Items.Clear();
                QntyTextBox.Clear();
                PriceTextBox.Clear();
                string query = "Select Name from Shawarma where Type = '" + TypeComboBox.SelectedItem.ToString() + "' ";
                Items = _dbAdapter.GetInList(query);
                foreach (string item in Items)
                {
                    NameComboBox.Items.Add(item);
                }
            }
        }

        private void GetTotalButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PriceTextBox.Text) || string.IsNullOrEmpty(QntyTextBox.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (decimal.TryParse(PriceTextBox.Text, out var price) && int.TryParse(QntyTextBox.Text, out var qnty))
            {
                TotalTextBox.Text = ((int)(qnty * price)).ToString();
            }
            else
            {
                MessageBox.Show("Invalid price or quantity format.");
            }
        }
    }
}
