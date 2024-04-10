namespace BlazorApp.Components.Shared;

using Global;
using Syncfusion.Blazor.Navigations;
using static Global.Data;
using Microsoft.AspNetCore.Components.Web;
//这个using 用不到_import.cs ??
// TO DO: 也许可以 onInitial DateDropList
// TO DO: button 加上disable?
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
        if (DateSkipValue < _tableHeaderDates.Count - 7)
            DateSkipValue += 7;
    }


    private readonly List<TableHeaderDate> _tableHeaderDates = TableHeaderDates;
    private readonly List<DateDropListItem> _dateDropList = DateDropList;
    private readonly List<UserInfo> _userInofs = UserInofs;
    SfPager? Page;
    public int SkipValue;
    public int TakeValue;
    public int LastItemInThePage;
    private readonly List<int> _pageSizes = [5, 10, 12, 20];

    //TO DO:也许可以加一个功能,选择_pageSizes时, 刷新页面.即当pagesize改变的时候 ,rerender
    protected override void OnInitialized()
    {
        base.OnInitialized();
        TakeValue = _pageSizes[0];
        LastItemInThePage = SkipValue + TakeValue;
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
