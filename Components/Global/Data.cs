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
    public static readonly List<DateDropListItem> DateDropList =
    [
        new() { DateSkipValue = 0, Text = "05 - 11 February 2024" },
        new() { DateSkipValue = 7, Text = "12 - 18 February 2024" },
        new() { DateSkipValue = 14, Text = "19 - 25 February 2024" }
    ];

    public static readonly List<DateOnly> TableHeaderDates =
    [
        new(2024, 2, 5),
        new(2024, 2, 6),
        new(2024, 2, 7),
        new(2024, 2, 8),
        new(2024, 2, 9),
        new(2024, 2, 10),
        new(2024, 2, 11),
        new(2024, 2, 12),
        new(2024, 2, 13),
        new(2024, 2, 14),
        new(2024, 2, 15),
        new(2024, 2, 16),
        new(2024, 2, 17),
        new(2024, 2, 18),
        new(2024, 2, 19),
        new(2024, 2, 20),
        new(2024, 2, 21),
        new(2024, 2, 22),
        new(2024, 2, 23),
        new(2024, 2, 24),
        new(2024, 2, 25)
    ];
    public static readonly List<UserInfo> UserInofs =
    [
        new()
        {
            Id = "0",
            Name = "Javier Holloway test",
            LastActive = "22/02/24",
            Team = "MARKETING",
            Appointments =
            [
                new()
                {
                    Content = "How to Overcome Procrastination",
                    BeginTime = new(2024, 2, 4, 14, 0, 0),
                    EndTime = new(2024, 2, 6, 14, 27, 0),
                    Background = "#EEF5FC",
                    BorderColor = "rgba(0, 19, 96, 0.5)",
                    Color = "#001360",
                    Duration = 1,
                    Info = "Module: Module 1, Started: Yes, Start Times: 3"
                },
                new()
                {
                    Content = "How to Overcome Procrastination",
                    BeginTime = new(2024, 2, 6, 14, 0, 0),
                    EndTime = new(2024, 2, 6, 14, 27, 0),
                    Background = "#EEF5FC",
                    BorderColor = "rgba(0, 19, 96, 0.5)",
                    Color = "#001360",
                    Duration = 1,
                    Info = "Module: Module 1, Started: Yes, Start Times: 3"
                },
                new()
                {
                    Content = "The 25-5 Rule",
                    BeginTime = new(2024, 2, 8, 14, 0, 0),
                    EndTime = new(2024, 2, 8, 14, 30, 0),
                    Background = "#FFEDD1",
                    BorderColor = "rgba(155, 94, 8, 0.5)",
                    Color = "#9B5E08",
                    Duration = 2,
                    Info = "Module: Module 1, Started: Yes, Start Times: 3"
                },
                new()
                {
                    Content = "The 25-5 Rule",
                    BeginTime = new(2024, 2, 10, 14, 0, 0),
                    EndTime = new(2024, 2, 14, 14, 0, 0),
                    Background = "#FFEDD1",
                    BorderColor = "rgba(155, 94, 8, 0.5)",
                    Color = "#9B5E08",
                    Duration = 2,
                    Info = "Module: Module 1, Started: Yes, Start Times: 3"
                },
                   new()
                {
                    Content = "The 25-6 Rule",
                    BeginTime = new(2024, 2, 16, 14, 0, 0),
                    EndTime = new(2024, 2, 17, 14, 30, 0),
                    Background = "#EEF5FC",
                    BorderColor = "rgba(0, 19, 96, 0.5)",
                    Color = "#001360",
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
            Team = "MARKETING",
             Appointments =
            [ new()
                {
                    Content = "How to Overcome Procrastination",
                    BeginTime = new(2024, 2, 5, 14, 0, 0),
                    EndTime = new(2024, 2, 7, 14, 30, 0),
                    Background = "#F1FBF8",
                    BorderColor = "rgba(0, 122, 82, 0.5)",
                    Color = "#007A52",
                    Duration = 2,
                    Info = "Module: Module 1, Started: Yes, Start Times: 3"
                },
                new()
                {
                    Content = "Title ABC",
                    BeginTime = new(2024, 2, 9, 14, 0, 0),
                    EndTime = new(2024, 2, 9, 14, 30, 0),
                    Background = "rgba(218, 8, 8, 0.1)",
                    BorderColor = "#EE9191",
                    Color = "#DA0808",
                    Duration = 2,
                    Info = "Module: Module 1, Started: Yes, Start Times: 3"
                },
                ]
        },
        new()
        {
            Id = "2",
            Name = "Javier Holloway",
            LastActive = "22/02/24",
            Team = "MARKETING",
            Appointments=[
                new()
                {
                    Content = "Title XYZ",
                    BeginTime = new(2024, 2, 6, 14, 0, 0),
                    EndTime = new(2024, 2, 6, 14, 30, 0),
                    Background = "rgba(218, 8, 8, 0.1)",
                    BorderColor = "#EE9191",
                    Color = "#DA0808",
                    Duration = 2,
                    Info = "Module: Module 1, Started: Yes, Start Times: 3"
                },
            ]
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
                    BeginTime = new(2024, 2, 5, 14, 0, 0),
                    EndTime = new(2024, 2, 7, 14, 27, 0),
                    Background = "#EEF5FC",
                    BorderColor = "rgba(0, 19, 96, 0.5)",
                    Color = "#001360",
                    Duration = 2,
                    Info = "Module: Module 1, Started: Yes, Start Times: 3"
                },
                new()
                {
                    Content = "The 25-5 Rule",
                    BeginTime = new(2024, 2, 8, 14, 0, 0),
                    EndTime = new(2024, 2, 8, 14, 27, 0),
                    Background = "#FFEDD1",
                    BorderColor = "rgba(155, 94, 8, 0.5)",
                    Color = "#9B5E08",
                    Duration = 1,
                    Info = "Module: Module 1, Started: No, Start Times: 0"
                },
                new()
                {
                    Content = "The 25-6 Rule",
                    BeginTime = new(2024, 2, 13, 14, 0, 0),
                    EndTime = new(2024, 2, 14, 14, 27, 0),
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
