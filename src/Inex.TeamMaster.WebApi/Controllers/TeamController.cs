using Inex.TeamMaster.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Inex.TeamMaster.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TeamController : ControllerBase
{
    private static Team _team = new Team("default");
    private readonly ILogger<TeamController> _logger;

    public TeamController(ILogger<TeamController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetTeamMembers")]
    public IEnumerable<Person> Get()
    {
        return _team.TeamMembers;
    }
    
    [HttpPost(Name = "AddTeamMember")]
    public void Add(Person person)
    {
        _team.AddTeamMember(person);
    }
}
