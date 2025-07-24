
namespace RegisterAndLoginApp.Models
{
    public class UserCollection : IUserManager
    {
        private List<UserModel> _users;

        public UserCollection() 
        {
            _users = new List<UserModel>();
            GenerateUserData();                                                     // generate some fake users
        }

        public void GenerateUserData()
        {
            UserModel user1 = new UserModel();
            user1.Username = "Kohl";
            user1.SetPassword("Salt2233");
            user1.Groups = "Admin";
            AddUser(user1);

            UserModel user2 = new UserModel();
            user2.Username = "Harry";
            user2.SetPassword("prince");
            user1.Groups = ("Admin, User");
            AddUser(user2);
        }

        public int AddUser(UserModel user)
        {
            user.Id = _users.Count + 1;                                             // set users Id to next available number (index of list)
            _users.Add(user);                                                       // add new user to list of users
            return user.Id;                                                         // return the new user's Id
        }

        public int CheckCredentials(string username, string password)
        {
            foreach (UserModel user in _users)
            {
                if (user.Username == username && user.VerifyPassword(password))
                {
                    return user.Id;                                                 // return user id
                }
            }
            return 0;                                                               // return 0 if no matches found (invalid login)
        }

        public void DeleteUser(UserModel user)
        {
            _users.Remove(user);                                                    // remove sepcified user
        }

        public List<UserModel> GetAllUsers()
        {
            return _users;                                                          // return user list
        }

        public UserModel GetUserById(int id)
        {
            foreach (UserModel user in _users) 
            {
                if (user.Id == id) return user;                                     // return matching user
            }
            return null;                                                            // return null if no match found
        }

        public void UpdateUser(UserModel user)
        {
            UserModel findUser = GetUserById(user.Id);                              // will hold the UserModel of the found user
            if (findUser != null)
            {
                int index = _users.IndexOf(findUser);                               // index in list with matching UserModel
                _users[index] = user;                                               // overwrite old with new UserModel (update)
            }
        }
    }
}
