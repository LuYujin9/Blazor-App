namespace BlazorApp.Components.Shared;

using Global;
using Syncfusion.Blazor.Navigations;

public partial class Table : ComponentBase
{
    private List<TableHeaderDate> _tableHeaderDates =
    [
        new()
        {
            Date = 2,
            Day = "Mon",
            IsToday = false
        },
        new()
        {
            Date = 3,
            Day = "Tue",
            IsToday = false
        },
        new()
        {
            Date = 4,
            Day = "Wed",
            IsToday = true
        },
        new()
        {
            Date = 5,
            Day = "Thu",
            IsToday = false
        },
        new()
        {
            Date = 6,
            Day = "Fri",
            IsToday = false
        },
        new()
        {
            Date = 7,
            Day = "Sat",
            IsToday = false
        },
        new()
        {
            Date = 8,
            Day = "Sun",
            IsToday = false
        }
    ];
    private List<DropListItem> _dateDropList = new List<DropListItem>
    {
        new DropListItem() { Id = "0", Text = "02 - 08 February 2024" },
        new DropListItem() { Id = "1", Text = "09 - 15 February 2024" },
        new DropListItem() { Id = "2", Text = "16 - 22 February 2024" }
    };
    private List<UserInfo> _userInofs = new List<UserInfo>()
    {
        new UserInfo()
        {
            Id = "0",
            Name = "Javier Holloway",
            LastActive = "22/02/24",
            Team = "MARKETING",
            Appointments = new List<Appointment>()
            {
                new Appointment()
                {
                    Content = "How to Overcome Procrastination",
                    Date = "03.02.2024",
                    BeginTime = "14:00",
                    EndTime = "14:27",
                    Background = "#EEF5FC",
                    BorderColor = "rgba(0, 19, 96, 0.5)",
                    Color = "#001360",
                    Duration = 1,
                    Info = "Module: Module 1, Started: Yes, Start Times: 3"
                },
                new Appointment()
                {
                    Content = "The 25-5 Rule",
                    Date = "05.02.2024",
                    BeginTime = "14:00",
                    Background = "#FFEDD1",
                    BorderColor = "rgba(155, 94, 8, 0.5)",
                    Color = "#9B5E08",
                    Duration = 2,
                    Info = "Module: Module 1, Started: Yes, Start Times: 3"
                }
            }
        },
        new UserInfo()
        {
            Id = "1",
            Name = "Javier Holloway",
            LastActive = "22/02/24",
            Team = "MARKETING"
        },
        new UserInfo()
        {
            Id = "2",
            Name = "Javier Holloway",
            LastActive = "22/02/24",
            Team = "MARKETING"
        },
        new UserInfo()
        {
            Id = "3",
            Name = "Javier Holloway",
            LastActive = "22/02/24",
            Team = "MARKETING"
        },
        new UserInfo()
        {
            Id = "4",
            Name = "Javier Holloway",
            LastActive = "22/02/24",
            Team = "MARKETING"
        },
        new UserInfo()
        {
            Id = "5",
            Name = "Javier Holloway",
            LastActive = "22/02/24",
            Team = "MARKETING"
        },
        new UserInfo()
        {
            Id = "0",
            Name = "Derek Larson 1",
            LastActive = "12/02/24",
            Team = "DEPARTMENT",
            Appointments = new List<Appointment>()
            {
                new Appointment()
                {
                    Content = "How to Overcome Procrastination",
                    Date = "03.02.2024",
                    BeginTime = "14:00",
                    EndTime = "14:27",
                    Background = "#EEF5FC",
                    BorderColor = "rgba(0, 19, 96, 0.5)",
                    Color = "#001360",
                    Duration = 2,
                    Info = "Module: Module 1, Started: Yes, Start Times: 3"
                },
                new Appointment()
                {
                    Content = "The 25-5 Rule",
                    Date = "05.02.2024",
                    BeginTime = "14:00",
                    Background = "#FFEDD1",
                    BorderColor = "rgba(155, 94, 8, 0.5)",
                    Color = "#9B5E08",
                    Duration = 1,
                    Info = "Module: Module 1, Started: No, Start Times: 0"
                }
            }
        },
        new UserInfo()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new UserInfo()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new UserInfo()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new UserInfo()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new UserInfo()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new UserInfo()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new UserInfo()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new UserInfo()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new UserInfo()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "22/02/24",
            Team = "DEPARTMENT"
        }
    };
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

    public class Team
    {
        public required string TeamName { get; set; }
        public required List<UserInfo> Users { get; set; }
    }

    public class TableHeaderDate
    {
        public required int Date { get; set; }
        public required string Day { get; set; }
        public required bool IsToday { get; set; }
    }
}
