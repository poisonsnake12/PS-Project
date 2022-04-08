using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static public class UserData
    {
        static private List<User> _testUsers;
        static public List<User> TestUsers
        {
            get 
            {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }
        static private void ResetTestUserData()
        {

            if (_testUsers == null)
            {
                _testUsers = new List<User>(3);

                _testUsers.Add(new User());
                _testUsers[0].username = "ADMIN";
                _testUsers[0].password = "admin";
                _testUsers[0].facultyNumber = "000000001";
                _testUsers[0].userRole = 1;
                _testUsers[0].dateCreated = DateTime.Now;
                _testUsers[0].validUntil = DateTime.MaxValue;

                _testUsers.Add(new User());
                _testUsers[1].username = "IvanFimov";
                _testUsers[1].password = "321654";
                _testUsers[1].facultyNumber = "321456789";
                _testUsers[1].userRole = 2;
                _testUsers[1].dateCreated = DateTime.Now;
                _testUsers[1].validUntil = DateTime.MaxValue;

                _testUsers.Add(new User());
                _testUsers[2].username = "Petar";
                _testUsers[2].password = "321874";
                _testUsers[2].facultyNumber = "843453489";
                _testUsers[2].userRole = 2;
                _testUsers[2].dateCreated = DateTime.Now;
                _testUsers[2].validUntil = DateTime.MaxValue;
            }
        } 

        static public User IsUserPassCorrect(string user, string pass)
        {
            User login = (from u in _testUsers where u.username == user && u.password == pass select u).First();

            if (login != null)
                return login;
            return null;//check if spits out null by mistake just in case
        }

        static public void SetUserActiveTo(string username, DateTime newDate)
        {
            foreach (User u in _testUsers)
            {
                if (u.username == username)
                {
                    u.validUntil = newDate;
                    Logger.LogActivity("Activity date changed of user: " + username);
                }
            }
        }

        static public void AssignUserRole (string username, UserRoles newRole)
        {
            foreach (User u in _testUsers)
            {
                if (u.username == username)
                {
                    u.userRole = Convert.ToInt32(newRole);
                    Logger.LogActivity("Role changed of user: " + username);
                }
            }
        }
    }
}
