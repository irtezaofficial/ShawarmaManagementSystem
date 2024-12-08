namespace ShawarmaManagementSystem
{
    public class ChickenShawarmaFactory : ShawarmaFactory
    {
        public override Shawarma CreateShawarma(string name, decimal price, int quantity)
        {
            return new ChickenShawarma(name, price, quantity);
        }
    }
}
