namespace Sample.Domain
{
    class Person
    {
        private readonly string _title;
        private readonly string _name;
        private readonly string _surname;

        public Person(string name) : this(null, name, null) { }

        public Person(string title, string name, string surame)
        {
            _title = title;
            _name = name;
            _surname = surame;
        }

        public string Title
        {
            get { return _title; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Surname
        {
            get { return _surname; }
        }

        public Person ChangeTitle(string title)
        {
            return new Person(title, this.Name, this.Surname);
        }

        public Person ChangeName(string name)
        {
            return new Person(this.Title, name, this.Surname);
        }

        public Person ChangeSurname(string surname)
        {
            return new Person(this.Title, this.Name, surname);
        }
    }
}
