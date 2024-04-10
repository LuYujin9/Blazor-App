namespace Global;

public class Data
{
    public static readonly List<DropListItem> CompanyDropList =
    [
        new() { Id = "0", Text = "Acme Inc" }
    ];
    public static readonly List<DropListItem> UserDropList =
    [
        new() { Id = "0", Text = "Label, Label, Label, Label, Label, Label," },
        new() { Id = "1", Text = "Label, Label, Label, Label, Label, Label," },
        new() { Id = "2", Text = "Label, Label, Label, Label, Label, Label," },
        new() { Id = "3", Text = "Label, Label, Label, Label, Label, Label," }
    ];
    public static readonly List<DropListItem> FilterDropList =
    [
        new() { Id = "0", Text = "Having Course today" }
    ];
    public static readonly List<DropListItem> SortDropList =
    [
        new() { Id = "0", Text = "Newest Users" },
        new() { Id = "1", Text = "Last Active" },
    ];
    public static readonly List<TableHeaderDate> TableHeaderDates =
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
    public static readonly List<DropListItem> DateDropList =
    [
        new() { Id = "0", Text = "02 - 08 February 2024" },
        new() { Id = "1", Text = "09 - 15 February 2024" },
        new() { Id = "2", Text = "16 - 22 February 2024" }
    ];
    public static readonly List<UserInfo> UserInofs =
    [
        new()
        {
            Id = "0",
            Name = "Javier Holloway",
            LastActive = "22/02/24",
            Team = "MARKETING",
            Appointments =
            [
                new()
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
                new()
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
            ]
        },
        new()
        {
            Id = "1",
            Name = "Javier Holloway",
            LastActive = "22/02/24",
            Team = "MARKETING"
        },
        new()
        {
            Id = "2",
            Name = "Javier Holloway",
            LastActive = "22/02/24",
            Team = "MARKETING"
        },
        new()
        {
            Id = "3",
            Name = "Javier Holloway",
            LastActive = "22/02/24",
            Team = "MARKETING"
        },
        new()
        {
            Id = "4",
            Name = "Javier Holloway",
            LastActive = "22/02/24",
            Team = "MARKETING"
        },
        new()
        {
            Id = "5",
            Name = "Javier Holloway",
            LastActive = "22/02/24",
            Team = "MARKETING"
        },
        new()
        {
            Id = "0",
            Name = "Derek Larson 1",
            LastActive = "12/02/24",
            Team = "DEPARTMENT",
            Appointments =
            [
                new()
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
                new()
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
            ]
        },
        new()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "12/02/24",
            Team = "DEPARTMENT"
        },
        new()
        {
            Id = "0",
            Name = "Derek Larson",
            LastActive = "22/02/24",
            Team = "DEPARTMENT"
        }
    ];
}
