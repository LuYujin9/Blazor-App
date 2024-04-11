namespace BlazorApp.Components.Pages;
using Global;
using static Global.Data;

public partial class Home
{
    private readonly List<DropListItem> _companyDropList = CompanyDropList;
    private readonly List<DropListItem> _userDropList = UserDropList;
    public string? SelectedCompany;
    public string? SelectedUser;
}