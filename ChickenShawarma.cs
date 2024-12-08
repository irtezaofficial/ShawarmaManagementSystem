namespace ShawarmaManagementSystem
{
    public class ChickenShawarma : Shawarma
    {
        public ChickenShawarma(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Type = ShawarmaType.Chicken;
        }

        public override ShawarmaType GetShawarmaType()
        {
            return Type;
        }

        public override string GetDescription()
        {
            return "Chicken Shawarma";
        }
    }
}
