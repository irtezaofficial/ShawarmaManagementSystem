namespace ShawarmaManagementSystem
{
    public abstract class ShawarmaFactory
    {
        public abstract Shawarma CreateShawarma(string name, decimal price, int quantity);
    }
}
