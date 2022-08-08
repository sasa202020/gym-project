
namespace GymApp.Models
{
    public class GymAppDbContext: IdentityDbContext<AppUser>
    {
        public GymAppDbContext(){ }

        public GymAppDbContext(DbContextOptions<GymAppDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("GymAppConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }

        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<ExerciseSpecification> ExercisesSpecifications { get; set; }
        public virtual DbSet<ExerciseType> ExercisesTypes { get; set; }
        public virtual DbSet<PlannedWorkOut> PlannedWorkOuts { get; set; }
        public virtual DbSet<SelectedExercise> SelectedExercises { get; set; }
        public virtual DbSet<WorkOut> WorkOuts { get; set; }
    }
}
