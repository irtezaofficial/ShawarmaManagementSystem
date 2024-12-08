namespace ShawarmaManagementSystem
{
    public class BeefShawarma : Shawarma
    {
        public BeefShawarma(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Type = ShawarmaType.Beef;
        }

        public override ShawarmaType GetShawarmaType()
        {
            return Type;
        }

        public override string GetDescription()
        {
            return "Beef Shawarma";
        }
    }
}
