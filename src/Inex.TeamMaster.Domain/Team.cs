namespace Inex.TeamMaster.Domain;

public class Team
{
    private readonly List<Person> _teamMembers = new();
    
    public Team(string teamName)
    {
        TeamName = teamName;
    }

    public string TeamName { get; }
    
    public IReadOnlyList<Person> TeamMembers => _teamMembers.AsReadOnly();
    
    public void AddTeamMember(Person person)
    {
        _teamMembers.Add(person);    
    }
}