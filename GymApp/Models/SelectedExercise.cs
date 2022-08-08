namespace GymApp.Models
{
    public class SelectedExercise
    {
        [Key]
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public Exercise Exercise { get; set; }

    }
}
