namespace ShawarmaManagementSystem
{
    public class ShawarmaManager
    {
        private static ShawarmaManager? _instance;
        private readonly IDatabaseAdapter _dbAdapter;
        private List<Shawarma> _shawarmas;

        private ShawarmaManager()
        {
            _dbAdapter = new DatabaseAdapter();
            _shawarmas = [];
        }

        public static ShawarmaManager Instance()
        {
            _instance ??= new ShawarmaManager();
            return _instance;
        }

        public void AddShawarma(Shawarma shawarma)
        {
            string query = "Insert into Shawarma values ('" + shawarma.Name + "','" + shawarma.Type + "','" + shawarma.Price + "','" + shawarma.Quantity + "');";
            string rec = _dbAdapter.Executecmd(query);
            string des = shawarma.GetShawarmaType().ToString();
            MessageBox.Show(rec + " in " + des);
        }

        public void RemoveShawarma(string name)
        {
            string query = "Delete from Shawarma where \"Name\" = '" + name + "'";
            string rec = _dbAdapter.Executecmd(query);
            MessageBox.Show(rec);
        }

        public void UpdateShawarma(string name, int quantity)
        {
            string query = "Update Shawarma set Quantity = '" + quantity + "' where \"Name\" = '" + name + "';";
            string rec = _dbAdapter.Executecmd(query);
            MessageBox.Show(rec);
        }
    }
}
