namespace ShawarmaManagementSystem
{
    public abstract class Shawarma
    {
        public string Name { get; protected set; } = default!;
        public decimal Price { get; protected set; }
        public ShawarmaType Type { get; protected set; }
        public int Quantity { get; protected set; }

        public abstract ShawarmaType GetShawarmaType();
        public abstract string GetDescription();
    }
}
