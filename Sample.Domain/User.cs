using System.Security;

namespace Sample.Domain
{
    public class User
    {
        private readonly string _login;
        private readonly SecureString _password;
        private readonly bool _enabled;
        private readonly Person _person;

        public User(string login, string title, string name, string surname, SecureString password, bool enabled)
        {
            _login = login;
            _password = password;
            _enabled = enabled;
            _person = new Person(title, name, surname);
        }

        public string Login
        {
            get { return _login; }
        }

        public bool Enabled
        {
            get { return _enabled; }
        }

        public string Title
        {
            get { return _person.Title; }
        }

        public string Name
        {
            get { return _person.Name; }
        }

        public string Surname
        {
            get { return _person.Surname; }
        }
    }
}
