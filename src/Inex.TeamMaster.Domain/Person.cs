namespace Inex.TeamMaster.Domain;

public class Person
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
}