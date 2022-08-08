namespace GymApp.Models
{
    public class PlannedWorkOut
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
