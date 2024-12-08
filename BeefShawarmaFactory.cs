namespace ShawarmaManagementSystem
{
    public class BeefShawarmaFactory : ShawarmaFactory
    {
        public override Shawarma CreateShawarma(string name, decimal price, int quantity)
        {
            return new BeefShawarma(name, price, quantity);
        }
    }
}
