
namespace BlazorApp.Components.Shared;

using Global;

public partial class AppointmentBlock
{
    [Parameter]
    public required Appointment Appointment { get; set; }
    [Parameter]
    public int AppointmentIndex { get; set; }
    [Parameter]
    public int RowCount { get; set; }
    private string _width = "100%";
    private int dayOfWeek;
    private int weekDayIndex;
    private int durationDay;
    // public string Color;
    // public string BorderColor;
    // public string Background;

    //  (Color, BorderColor, Background) = Appointment.GetColors();
    // question: 如何在这里定义color, border,....


    // question 结束时间超过星期天, 就不显示
    // question 为什么第一个appointment的位置没有更新, 内容却更新了
    protected override void OnParametersSet()
    {
        if (Appointment != null)
        {
            dayOfWeek = (int)DateOnly.FromDateTime(Appointment.BeginTime).DayOfWeek;
            weekDayIndex = (dayOfWeek - 1 + 7) % 7;
            durationDay = Appointment.EndTime.DayOfYear - Appointment.BeginTime.DayOfYear + 1;
            _width = ((durationDay + weekDayIndex < 8 ? durationDay : 7.05 - weekDayIndex) * 100).ToString() + "%";
        }
    }


}
