namespace GymApp.Models
{
    public class ExerciseType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public IEnumerable<Exercise>? Exercises { get; set; }
    }
}
