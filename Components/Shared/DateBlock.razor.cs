namespace BlazorApp.Components.Shared;

using Global;

public partial class DateBlock
{
    [Parameter]
    public Appointment? Appointment { get; set; }

    protected override void OnInitialized()
    {
        if (Appointment != null)
        {
            _width = ((Appointment?.Duration ?? 0) * 100).ToString() + "%";
        }
        //question: 为什么当超过100%的时候,是用113.75来算的.
    }

    private string _width = "100%";
}
