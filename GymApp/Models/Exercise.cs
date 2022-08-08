namespace GymApp.Models
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(2000)]
        public string? Description { get; set; }
        public string? PicturePath { get; set; }
        [Required]
        public int ExerciseTypeId { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public ExerciseSpecification? ExerciseSpecification { get; set; }   
    }
}
