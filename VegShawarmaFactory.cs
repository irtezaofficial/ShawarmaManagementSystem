namespace ShawarmaManagementSystem
{
    public class VegShawarmaFactory : ShawarmaFactory
    {
        public override Shawarma CreateShawarma(string name, decimal price, int quantity)
        {
            return new VegShawarma(name, price, quantity);
        }
    }
}
