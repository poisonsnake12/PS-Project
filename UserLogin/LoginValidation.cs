using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {
        static public string userName
            {
                get; private set;
            }
        static public string password
        {
            get; private set;
        }

        private string errorMessage;

        public delegate void ActionOnError(string _errorMessage);

        private ActionOnError _onError;
        public LoginValidation (string user, string pass, ActionOnError error)
        {
            userName = user;
            password = pass;
            _onError = error;
        }
        static public UserRoles currentUserRole
        { get; private set; }
        public bool ValidateUserInput(ref User user)
        {
            User newUser = new User();

            if (userName.Equals(String.Empty))
            {
                errorMessage = "Empty username";
                _onError(errorMessage);
                return false;
            }
            if (password.Equals(String.Empty))
            {
                errorMessage = "Empty password";
                _onError(errorMessage);

                return false;
            }
            if (userName.Length < 5)
            {
                errorMessage = "Username too short. Must be length 5 or above.";
                _onError(errorMessage);

                return false;
            }
            if (password.Length < 5)
            {
                errorMessage = "Password too short. Must be length 5 or above.";
                _onError(errorMessage);

                return false;
            }
            if (UserData.IsUserPassCorrect(userName, password) != null)
            {
                newUser = UserData.IsUserPassCorrect (userName, password);
                user = newUser;
                currentUserRole = (UserRoles)user.userRole;
                Logger.LogActivity("Successful Login");
                return true;
            }
            errorMessage = "Invalid login information";
            currentUserRole = (UserRoles)0;
            return false;
        }
    }
}
