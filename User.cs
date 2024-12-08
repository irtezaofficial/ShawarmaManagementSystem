namespace ShawarmaManagementSystem
{
    public class User
    {
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public UserType Type { get; set; }
    }
}
