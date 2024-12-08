using Newtonsoft.Json;

namespace ShawarmaManagementSystem
{
    internal class LoginService : ILoginService
    {
        private readonly IDatabaseAdapter _dbAdapter;

        public LoginService(IDatabaseAdapter dbAdapter)
        {
            _dbAdapter = dbAdapter ?? throw new ArgumentNullException(nameof(dbAdapter));
        }

        public User? Login(string username, string password)
        {
            string userQuery = $"Select * from Users where UserName = '{username}' AND Password = '{password}'";
            var res = _dbAdapter.ExecuteSingleQuery(userQuery);
            return JsonConvert.DeserializeObject<User?>(res);
        }
    }
}
