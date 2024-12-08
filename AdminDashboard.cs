using System.Data;

namespace ShawarmaManagementSystem
{
    public partial class AdminDashboard : Form
    {
        private ShawarmaFactory? _shawarmaFactory;
        private ShawarmaManager _manager;
        private IDatabaseAdapter _dbAdapter;
        DataTable? dataTable;
        public AdminDashboard()
        {
            _manager = ShawarmaManager.Instance();
            _dbAdapter = new DatabaseAdapter();
            InitializeComponent();
            LoadShawarmaList();
        }

        private void DashboardColumns()
        {
            ShawarmaList.Columns[0].HeaderCell.Value = "Name";
            ShawarmaList.Columns[1].HeaderCell.Value = "Type";
            ShawarmaList.Columns[2].HeaderCell.Value = "Price";
            ShawarmaList.Columns[3].HeaderCell.Value = "Quantity";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(SearchTextBox.Text))
                {
                    string query = "Select * from Shawarma";
                    ShawarmaList.DataSource = null;
                    dataTable = _dbAdapter.GetShawarmaList(query);
                    ShawarmaList.DataSource = dataTable;
                    DashboardColumns();
                }
                else
                {
                    string query = $"Select * from Shawarma Where \"Name\" LIKE '%{SearchTextBox.Text}%'";
                    ShawarmaList.DataSource = null;
                    dataTable = _dbAdapter.GetShawarmaList(query);
                    ShawarmaList.DataSource = dataTable;
                    DashboardColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void LoadShawarmaList()
        {
            string query = "Select * from Shawarma";
            dataTable = _dbAdapter.GetShawarmaList(query);
            ShawarmaList.DataSource = dataTable;
            DashboardColumns();
        }

        private void ClearShawarmaList()
        {
            ShawarmaList.DataSource = null;
        }

        private void ClearData()
        {
            NameTextBox.Text = string.Empty;
            QntyTextBox.Text = string.Empty;
            PriceTextBox.Text = string.Empty;
            TypeComboBox.SelectedItem = null;
            LoadShawarmaList();
        }

        private void ShawarmaList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var shawarmaType = ShawarmaList.Rows[e.RowIndex].Cells[1].Value.ToString();
            TypeComboBox.Text = GetShawarmaType(shawarmaType)?.ToString();
            NameTextBox.Text = ShawarmaList.Rows[e.RowIndex].Cells[0].Value.ToString();
            PriceTextBox.Text = ShawarmaList.Rows[e.RowIndex].Cells[2].Value.ToString();
            QntyTextBox.Text = ShawarmaList.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private static ShawarmaType? GetShawarmaType(string? shawarmaType)
        {
            if (shawarmaType == "0" || shawarmaType == ShawarmaType.Chicken.ToString())
                return ShawarmaType.Chicken;
            else if (shawarmaType == "1" || shawarmaType == ShawarmaType.Beef.ToString())
                return ShawarmaType.Beef;
            else if (shawarmaType == "2" || shawarmaType == ShawarmaType.Veg.ToString())
                return ShawarmaType.Veg;

            return null;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TypeComboBox.Text) ||
                string.IsNullOrEmpty(NameTextBox.Text) ||
                string.IsNullOrEmpty(QntyTextBox.Text) ||
                string.IsNullOrEmpty(PriceTextBox.Text))
            {
                MessageBox.Show("Fill all Feilds");
            }
            else
            {
                var type = TypeComboBox.Text;
                var shawarmaType = GetShawarmaType(type);
                string name = NameTextBox.Text;
                decimal price = Convert.ToDecimal(PriceTextBox.Text);
                int quantity = Convert.ToInt32(QntyTextBox.Text);

                switch (shawarmaType)
                {
                    case ShawarmaType.Chicken:
                        _shawarmaFactory = new ChickenShawarmaFactory();
                        break;

                    case ShawarmaType.Beef:
                        _shawarmaFactory = new BeefShawarmaFactory();
                        break;

                    case ShawarmaType.Veg:
                        _shawarmaFactory = new VegShawarmaFactory();
                        break;
                }

                if (_shawarmaFactory is not null)
                {
                    var shawarma = _shawarmaFactory.CreateShawarma(name, price, quantity);
                    _manager.AddShawarma(shawarma);
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Invalid Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TypeComboBox.Text) ||
                string.IsNullOrEmpty(NameTextBox.Text) ||
                string.IsNullOrEmpty(QntyTextBox.Text) ||
                string.IsNullOrEmpty(PriceTextBox.Text))
            {
                MessageBox.Show("Fill all Feilds");
            }
            else
            {
                string name = NameTextBox.Text;
                int quantity = Convert.ToInt32(QntyTextBox.Text);
                _manager.UpdateShawarma(name, quantity);
                ClearData();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            if (!string.IsNullOrEmpty(name))
            {
                _manager.RemoveShawarma(name);
                ClearData();
            }
        }
    }
}
