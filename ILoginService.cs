namespace ShawarmaManagementSystem
{
    internal interface ILoginService
    {
        User? Login(string username, string password);
    }
}
