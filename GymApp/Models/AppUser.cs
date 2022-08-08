namespace GymApp.Models
{
    public class AppUser: IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Date of birth")]
        public DateTime BirthDay { get; set; }

        [Display(Name ="Profile Picture")]
        public string? ImagePath { get; set; }
        public int? MonthGoal { get; set; }
        public int? YearGoal { get; set; }
        [Required]
        [StringLength(30)]
        public string GymName { get; set; }
        [Required]
        [StringLength(30)]
        public string GymCity { get; set; }
    }
}
