using System.Windows.Forms;

namespace ShawarmaManagementSystem
{
    public partial class OrderForm : Form
    {
        public int totalQuantity = 0;
        private List<string> Items;
        private Order _order;

        private readonly IDatabaseAdapter _dbAdapter;

        public OrderForm()
        {
            InitializeComponent();
            Items = new List<string>();
            _order = new Order();
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
                if (!string.IsNullOrEmpty(totalQuantityStr) && int.TryParse(totalQuantityStr, out totalQuantity))
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

        private void OrderForm_Load(object sender, EventArgs e)
        {
            StatusTextBox.Text = _order.GetOrderState();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(QntyTextBox.Text, out var qnty) &&
                decimal.TryParse(PriceTextBox.Text, out var price) &&
                int.TryParse(TotalTextBox.Text, out var total))
            {
                string query = $"Insert into Invoice values ('{NameComboBox.Text}', '{qnty}', '{price}', '{total}', '{DateTime.Now}', '{PaymentComboBox.Text}');";
                string rec = _dbAdapter.Executecmd(query);

                int quantity = totalQuantity - qnty;
                string query1 = $"Update Shawarma set Quantity = {quantity} where Name = '{NameComboBox.Text}';";
                _dbAdapter.Executecmd(query1);

                _order.SetOrderState(new ProcessingState());
                StatusTextBox.Text = _order.GetOrderState();
            }
            else
            {
                MessageBox.Show("Invalid data format.");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _order.CancelOrder();
            StatusTextBox.Text = _order.GetOrderState();
        }

        private void DeliveredButton_Click(object sender, EventArgs e)
        {
            _order.DeliverOrder();
            StatusTextBox.Text = _order.GetOrderState();
        }

        private void CompletedButton_Click(object sender, EventArgs e)
        {
            _order.CompleteOrder();
            StatusTextBox.Text = _order.GetOrderState();
        }
    }
}
