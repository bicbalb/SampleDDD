using System.Collections.Generic;

namespace Sample.Domain
{
    public class Company
    {
        private readonly GenericName _name;
        private readonly IList<Department> _departments;

        public Company(string name) : this(name, null) { }

        public Company(string name, string description)
        {
            _name = new GenericName(name, description);
            _departments = new List<Department>();
        }

        public string Name
        {
            get { return _name.Name; }
        }

        public string Description
        {
            get { return _name.Description; }
        }

        public Company ChangeName(string name)
        {
            return new Company(name, this.Description);
        }

        public Company ChangeDescription(string description)
        {
            return new Company(this.Name, description);
        }

        public void AddDepartment(Department department)
        {
            _departments.Add(department);
        }

        public void AddUser(User user, Department department)
        {
            department.AddUser(user);
        }
    }
}
