namespace RegisterAndLoginApp.Models
{
    public interface IUserManager
    {
        public List<UserModel> GetAllUsers();                               // return all users stored in the system
        public UserModel GetUserById(int id);                               // given an id number, find the matching user
        public int AddUser(UserModel user);                                 // add a new user to the list / db, for use during registration
        public void DeleteUser(UserModel user);                             // remove the matching user
        public void UpdateUser(UserModel user);                             // find the user with matching id and replace (update)
        public int CheckCredentials(string username, string password);      // for verifying logins
    }
}
