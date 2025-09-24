namespace EventEaseApp.Services
{
    public class UserSessionService
    {
        public string? UserName { get; private set; }
        public string? UserEmail { get; private set; }
        public bool IsRegistered => !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(UserEmail);

        public void RegisterUser(string name, string email)
        {
            UserName = name;
            UserEmail = email;
        }

        public void ClearSession()
        {
            UserName = null;
            UserEmail = null;
        }
    }
}
