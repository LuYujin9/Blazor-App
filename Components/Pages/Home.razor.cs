namespace BlazorApp.Components.Pages;
using Global;
using static Global.Data;

public partial class Home
{
    private readonly List<DropListItem> _companyDropList = CompanyDropList;
    private readonly List<DropListItem> _userDropList = UserDropList;
    private readonly List<DropListItem> _filterDropList = FilterDropList;
    private readonly List<DropListItem> _sortDropList = SortDropList;
    public string? SelectedCompany;
    public string? SelectedUser;
    public string? SelectedFilter;
    public string? SelectedSort;
}