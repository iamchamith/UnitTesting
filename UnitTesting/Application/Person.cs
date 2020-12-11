namespace UnitTesting
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool IsEmployee { get; set; }
        public Person(int id, string name, string address,bool isEmployee)
        {
            Id = id;
            Name = name;
            Address = address;
            IsEmployee = isEmployee;
        }
        public Person()
        {
        }
        public override bool Equals(object obj)
        {
            var a = obj as Person;
            return a.Id == Id && a.Name == Name && a.IsEmployee == IsEmployee && a.Address == Address;
        }
    }
}
