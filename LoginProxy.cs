namespace ShawarmaManagementSystem
{
    internal class LoginProxy : ILoginService
    {
        private readonly ILoginService _instance;
        private int FailedAttempts = 0;
        private const int MaxFailedAttempts = 3;

        public LoginProxy(ILoginService loginService)
        {
            _instance = loginService ?? throw new ArgumentNullException(nameof(loginService));
        }

        public User? Login(string username, string password)
        {
            if (FailedAttempts >= MaxFailedAttempts)
            {
                throw new UnauthorizedAccessException("Maximum login attempts exceeded.");
            }

            var user = _instance.Login(username, password);
            if (user is null)
            {
                FailedAttempts++;
            }
            else
            {
                FailedAttempts = 0; // reset on successful login
            }

            return user;
        }
    }
}
