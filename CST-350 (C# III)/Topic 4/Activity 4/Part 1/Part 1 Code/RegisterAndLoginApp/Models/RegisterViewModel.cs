namespace RegisterAndLoginApp.Models
{
    public class GroupViewModel
    {
        public bool IsSelected { get; set; }
        public string GroupName { get; set; }
    }
    
    
    public class RegisterViewModel
    {
        // Properties for RegisterViewModel
        public string Username { get; set; }
        public string Password { get; set; }
        public List<GroupViewModel> Groups { get; set; }


        // Constructor
        public RegisterViewModel()
        {
            Username = "";
            Password = "";
            Groups = new List<GroupViewModel>
            {
                new GroupViewModel { GroupName = "Admin", IsSelected = false },
                new GroupViewModel { GroupName = "Users", IsSelected = false },
                new GroupViewModel { GroupName = "Students", IsSelected = false }
            };
        }
    }
}
