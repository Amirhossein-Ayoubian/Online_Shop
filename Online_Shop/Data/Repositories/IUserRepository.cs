using Online_Shop.Models;

namespace Online_Shop.Data.Repositories
{
    public interface IUserRepository
    {
        public List<User> GetAllUsers();
        public User GetUserById(int id);
        public User GetUserByUsername(string username);
        public User GetCurrentUser();
        public void AddUser(User user);
        public void SetCurrentUser(User user);
    }

    public class UserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
            GetAllUsers().Add(user);
        }

        public List<User> GetAllUsers()
        {
            return Website.users;
        }

        public User GetCurrentUser()
        {
            return Website.currentUser;
        }

        public User GetUserById(int id)
        {
            return Website.users.Find(u => u.id == id);
        }

        public User GetUserByUsername(string username)
        {
            return Website.users.Find(u => u.username == username);
        }

        public void SetCurrentUser(User user)
        {
            Website.currentUser = user;
        }
    }
}
