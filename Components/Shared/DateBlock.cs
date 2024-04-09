 [Parameter]
    public Appointment? AppointmentParameter { get; set; }

    protected override void OnInitialized()
    {
        if (AppointmentParameter != null)
        {
            _width = ((AppointmentParameter?.Duration ?? 0) * 100).ToString() + "%";
        }
        //question: 为什么当超过100%的时候,是用113.75来算的.
    }
    private string _width = "100%";
    public class Appointment
    {
        public required string Content { get; set; }
        public required string Date { get; set; }
        public required string BeginnTime { get; set; }
        public string? EndTime { get; set; }
        public required string Background { get; set; }
        public required string BorderColor { get; set; }
        public required string Color { get; set; }
        public required int Duration { get; set; }
        public required string Info { get; set; }
    }