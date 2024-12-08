namespace ShawarmaManagementSystem
{
    public class VegShawarma : Shawarma
    {
        public VegShawarma(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Type = ShawarmaType.Veg;
        }

        public override ShawarmaType GetShawarmaType()
        {
            return Type;
        }

        public override string GetDescription()
        {
            return "Veg Shawarma";
        }
    }
}
