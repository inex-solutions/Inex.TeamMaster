using Xunit;

namespace Inex.TeamMaster.Domain.Tests;

public class TeamTests
{
    [Fact]
    public void AddTeamMember_AddsPersonToTeam()
    {
        // Arrange
        var team = new Team("Test Team");
        var person = new Person(1, "John", "Doe", "john.doe@example.com", new DateTime(1980, 1, 1));

        // Act
        team.AddTeamMember(person);

        // Assert
        Assert.Contains(person, team.TeamMembers);
    }

    [Fact]
    public void TeamMembers_WhenNoMembersAdded_ReturnsEmptyList()
    {
        // Arrange
        var team = new Team("Test Team");

        // Act
        var teamMembers = team.TeamMembers;

        // Assert
        Assert.Empty(teamMembers);
    }
}