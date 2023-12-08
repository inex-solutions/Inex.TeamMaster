using FluentAssertions;

namespace Inex.TeamMaster.Domain.Tests;

public class PersonTests
{
    [Fact]
    public void Person_ValueTypeEqualityAndHashcode_AreEqual()
    {
        // Arrange
        var person = new Person(1, "John", "Doe", "john.doe@example.com", new DateTime(1980, 3, 21));
        var personCopy = new Person(id: person.Id, firstname: person.Firstname, surname: person.Surname, emailAddress: person.EmailAddress, dateOfBirth: person.DateOfBirth);
        
        // Act
        personCopy.Should().Be(person, "because the two objects are Equal");
        personCopy.GetHashCode().Should().Be(person.GetHashCode(), "because the two objects have the same GetHashCode() value");
    }
    
    [Fact]
    public void Person_ValueTypeEqualityAndHashcode_DifferentId()
    {
        // Arrange
        var person = new Person(1, "John", "Doe", "john.doe@example.com", new DateTime(1980, 3, 21));
        var personCopy = new Person(id: 99, firstname: person.Firstname, surname: person.Surname, emailAddress: person.EmailAddress, dateOfBirth: person.DateOfBirth);
        
        // Act
        personCopy.Should().NotBe(person, "because the two objects are not Equal");
        personCopy.GetHashCode().Should().NotBe(person.GetHashCode(), "because the two objects do not have the same GetHashCode() value");
    }
    
    [Fact]
    public void Person_ValueTypeEqualityAndHashcode_DifferentFirstname()
    {
        // Arrange
        var person = new Person(1, "John", "Doe", "john.doe@example.com", new DateTime(1980, 3, 21));
        var personCopy = new Person(id: person.Id, firstname: "Rob", surname: person.Surname, emailAddress: person.EmailAddress, dateOfBirth: person.DateOfBirth);
        
        // Act
        personCopy.Should().NotBe(person, "because the two objects are not Equal");
        personCopy.GetHashCode().Should().NotBe(person.GetHashCode(), "because the two objects do not have the same GetHashCode() value");
    }
    
    [Fact]
    public void Person_ValueTypeEqualityAndHashcode_DifferentSurname()
    {
        // Arrange
        var person = new Person(1, "John", "Doe", "john.doe@example.com", new DateTime(1980, 3, 21));
        var personCopy = new Person(id: person.Id, firstname: person.Firstname, surname: "Levine", emailAddress: person.EmailAddress, dateOfBirth: person.DateOfBirth);
        
        // Act
        personCopy.Should().NotBe(person, "because the two objects are not Equal");
        personCopy.GetHashCode().Should().NotBe(person.GetHashCode(), "because the two objects do not have the same GetHashCode() value");
    }
    
    [Fact]
    public void Person_ValueTypeEqualityAndHashcode_DifferentEmail()
    {
        // Arrange
        var person = new Person(1, "John", "Doe", "john.doe@example.com", new DateTime(1980, 3, 21));
        var personCopy = new Person(id: person.Id, firstname: person.Firstname, surname: person.Surname, emailAddress: "robert.levine@schroders.com", dateOfBirth: person.DateOfBirth);
        
        // Act
        personCopy.Should().NotBe(person, "because the two objects are not Equal");
        personCopy.GetHashCode().Should().NotBe(person.GetHashCode(), "because the two objects do not have the same GetHashCode() value");
    }
    
    [Fact]
    public void Person_ValueTypeEqualityAndHashcode_DifferentDateOfBirth()
    {
        // Arrange
        var person = new Person(1, "John", "Doe", "john.doe@example.com", new DateTime(1980, 3, 21));
        var personCopy = new Person(id: person.Id, firstname: person.Firstname, surname: person.Surname, emailAddress: person.EmailAddress, dateOfBirth: new DateTime(1972, 03, 21));
        
        // Act
        personCopy.Should().NotBe(person, "because the two objects are not Equal");
        personCopy.GetHashCode().Should().NotBe(person.GetHashCode(), "because the two objects do not have the same GetHashCode() value");
    }
}