namespace GymApp.Models
{
    public class WorkOut
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int ExerciseTypeId { get; set; }
        public string AppUserId { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public AppUser AppUser { get; set; }

    }
}
