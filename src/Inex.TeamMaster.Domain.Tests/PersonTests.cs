namespace Inex.TeamMaster.Domain.Tests;

public class PersonTests
{
    [Fact]
    public void Person_ValueTypeEquality()
    {
        // Arrange
        var person = new Person(1, "John", "Doe", "john.doe@example.com", new DateTime(1980, 3, 21));
        var personCopy = new Person(id: person.Id, firstname: person.Firstname, surname: person.Surname, emailAddress: person.EmailAddress, dateOfBirth: person.DateOfBirth);
        
        // Act
        Assert.Equal(person, personCopy);
    }
}