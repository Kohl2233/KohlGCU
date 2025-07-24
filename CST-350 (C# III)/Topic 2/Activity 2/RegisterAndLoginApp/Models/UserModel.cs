
namespace RegisterAndLoginApp.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public byte[] Salt { get; set; }
        public string Groups { get; set; }

        internal void SetPassword(string v)
        {
            PasswordHash = v;
        }

        internal bool VerifyPassword(string password)
        {
            if (password == PasswordHash)
            {
                return true;
            }
            else
                return false;
        }
    }
}
