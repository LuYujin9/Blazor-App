
namespace BlazorApp.Components.Pages;
public partial class Test
{
    private readonly List<UserInfo> _userInfo = Data.UserInofs;

    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

    private List<Team> GetUsers()
    {
        return _userInfo
            .GroupBy(u => u.Team)
            .Select(g => new Team { TeamName = g.Key, Users = g.ToList() })
            .ToList();
    }

}
