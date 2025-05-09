using System;
using System.Threading.Tasks;

namespace EventApp
{
    public class UserSessionService
    {
        private string _currentUser;
        private bool _isLoggedIn;

        public event Action OnSessionChanged;

        public string CurrentUser => _currentUser;
        public bool IsLoggedIn => _isLoggedIn;

        public void Login(string username)
        {
            _currentUser = username;
            _isLoggedIn = true;
            NotifySessionChanged();
        }
        
        public void RegisterUser(User user)
        {
            _currentUser = user.Username;
            _isLoggedIn = true;
            NotifySessionChanged();
        }

        public void Logout()
        {
            _currentUser = null;
            _isLoggedIn = false;
            NotifySessionChanged();
        }

        public void NotifySessionChanged()
        {
            OnSessionChanged?.Invoke();
        }
    }
}
