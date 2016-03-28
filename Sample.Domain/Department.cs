using System.Collections.Generic;

namespace Sample.Domain
{
    public class Department
    {
        private readonly GenericName _name;
        private readonly IList<User> _users;

        public Department(string name) : this(name, null) { }

        public Department(string name, string description)
        {
            _name = new GenericName(name, description);
            _users = new List<User>();
        }

        public string Name
        {
            get { return _name.Name; }
        }

        public string Description
        {
            get { return _name.Description; }
        }

        public Department ChangeName(string name)
        {
            return new Department(name, this.Description);
        }

        public Department ChangeDescription(string description)
        {
            return new Department(this.Name, description);
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}
