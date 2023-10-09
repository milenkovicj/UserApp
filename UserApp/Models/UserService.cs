using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserApp.Models
{
    public class UserService
    {
        private readonly User user1;
        private readonly User user2;
        private List<User> users;

        public UserService()
        {
            user1 = new User(1, "Pera", "Peric", 25);
            user2 = new User(2, "Mika", "Mikic", 40);
            users = new List<User> { user1, user2 };
        }

        public List<User> GetAll()
        {
            return users;
        }

        public User GetById(int id)
        {
            User userById = users.Find(user => user.Id == id);

            return userById;
        }

        public void SaveUser(User user)
        {
            users.Add(user);
        }
    }
}
