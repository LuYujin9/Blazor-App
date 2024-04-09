namespace Global; 
 
 public class DropListItem
    {
        public string? Id { get; set; }
        public string? Text { get; set; }
    }
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