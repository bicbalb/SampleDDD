namespace Sample.Domain
{
    class GenericName
    {
        private readonly string _name;
        private readonly string _description;

        public GenericName(string name) : this(name, null) { }

        public GenericName(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Description
        {
            get { return _description; }
        }

        public GenericName ChangeName(string name)
        {
            return new GenericName(name, this.Description);
        }

        public GenericName ChangeDescription(string description)
        {
            return new GenericName(this.Name, description);
        }
    }
}
