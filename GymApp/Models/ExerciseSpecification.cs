namespace GymApp.Models
{
    public class ExerciseSpecification
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string? AmountParameter { get; set; }
        public int? Repetitions { get; set; }
        [StringLength(20)]
        public string? AmountUnits { get; set; }
        [StringLength(50)]
        public string? TimeParameter { get; set; }
        public int? Time { get; set; }
        [StringLength(20)]
        public string? TimeUnit { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }

    }
}
