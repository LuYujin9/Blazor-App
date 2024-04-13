namespace BlazorApp.Components.Shared;

using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor.Navigations;

// question 这个using 不能在_import.cs 也不能在imports.razor里 ??
// TO DO: 也许可以 onInitial DateDropList
public partial class Table : ComponentBase
{
    public int DateSkipValue { get; set; } = 0;
    private void PrevWeekClick(MouseEventArgs args)
    {
        if (DateSkipValue > 6)
        { DateSkipValue -= 7; }
    }

    private void NextWeekClick(MouseEventArgs args)
    {
        if (DateSkipValue < _dateList.Count - 7)
            DateSkipValue += 7;
    }

    private readonly List<DropListItem> _filterDropList = FilterDropList;
    private readonly List<DropListItem> _sortDropList = SortDropList;
    private readonly List<DateOnly> _dateList = TableHeaderDates;
    private readonly List<DateDropListItem> _dateDropList = DateDropList;
    private readonly List<UserInfo> _userInofs = UserInofs;

    private List<Team> GetTeams()
    {
        var currentUsers = _userInofs.Skip(SkipValue).Take(TakeValue).ToList();
        return currentUsers
                  .GroupBy(u => u.Team)
                  .Select(g => new Team { TeamName = g.Key, Users = g.ToList() })
                  .ToList();
    }

    private List<DateOnly> GetDate()
    {
        return _dateList.Skip(DateSkipValue).Take(7).ToList();
    }

    SfPager? Page;
    public int SkipValue;
    public int TakeValue;
    public int LastItemInThePage;
    public string? SelectedFilter;
    public string? SelectedSort;
    private readonly List<int> _pageSizes = [5, 10, 20];

    //TO DO:也许可以加一个功能,选择_pageSizes时, 刷新页面.即当pagesize改变的时候 ,rerender
    protected override void OnInitialized()
    {
        TakeValue = _pageSizes[1];
        LastItemInThePage = SkipValue + TakeValue;
        base.OnInitialized();
    }

    public void Click(PagerItemClickEventArgs args)
    {
        SkipValue = (args.CurrentPage * Page!.PageSize) - Page.PageSize;
        TakeValue = Page.PageSize;
        if (SkipValue >= Page.TotalItemsCount - TakeValue)
        {
            LastItemInThePage = Page.TotalItemsCount;
            return;
        }
        LastItemInThePage = SkipValue + TakeValue;
    }
}
