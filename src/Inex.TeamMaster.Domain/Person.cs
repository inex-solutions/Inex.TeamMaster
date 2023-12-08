namespace Inex.TeamMaster.Domain;

public class Person : IEquatable<Person>
{
    public Person(int id, string firstname, string surname, string emailAddress, DateTime dateOfBirth)
    {
        Id = id;
        Firstname = firstname;
        Surname = surname;
        EmailAddress = emailAddress;
        DateOfBirth = dateOfBirth;
    }

    public int Id { get; }

    public string Firstname { get; }

    public string Surname { get; }

    public string EmailAddress { get; }

    public DateTime DateOfBirth { get; }

    public override string ToString()
    {
        return
            $"Id: {Id}, Firstname: {Firstname}, Surname: {Surname}, EmailAddress: {EmailAddress}, DateOfBirth: {DateOfBirth}";
    }
    
        public bool Equals(Person? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && Firstname == other.Firstname && Surname == other.Surname && EmailAddress == other.EmailAddress && DateOfBirth.Equals(other.DateOfBirth);
        }
    
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Person)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Firstname, Surname, EmailAddress, DateOfBirth);
        }
}