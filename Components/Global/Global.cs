namespace Global;

public class DropListItem
{
    public string? Id { get; set; }
    public string? Text { get; set; }
}
public class DateDropListItem
{
    public int? DateSkipValue { get; set; }
    public string? Text { get; set; }
}

public class Appointment
{
    public required string Content { get; set; }
    public required string Date { get; set; }
    // TODO: change string to DateTime datatype
    public required string BeginTime { get; set; }
    public string? EndTime { get; set; }
    public required string Background { get; set; }
    public required string BorderColor { get; set; }
    public required string Color { get; set; }
    public required int Duration { get; set; }
    public required string Info { get; set; }

    public (string, string, string) GetColors()
    {
        return (Color, BorderColor, Background);
    }
}

public class UserInfo
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string LastActive { get; set; }
    public required string Team { get; set; }
    public List<Appointment>? Appointments { get; set; }
}

public class TableHeaderDate
{
    public required int Date { get; set; }
    public required string Day { get; set; }
    public required bool IsToday { get; set; }
}

public class Date
{
    public required int Day { get; set; }
    public required int Month { get; set; }
    public required int Year { get; set; }
}

public class Team
{
    public required string TeamName { get; set; }
    public required List<UserInfo> Users { get; set; }
}
