namespace GymApp.Services.Services
{
    public class SelectedExercicesService : ISelectedExercisesService
    {
        private readonly GymAppDbContext context;

        public SelectedExercicesService(GymAppDbContext context)
        {
            this.context = context;
        }
        public async Task AddSelectExercisesAsync(IEnumerable<Exercise> exercises, string userId)
        {
            foreach (var ex in exercises)
            {
                Exercise exToAdd = await context.Exercises.FirstOrDefaultAsync(x => x.Id == ex.Id);
                if (exToAdd != null)
                {
                    SelectedExercise selected = new() { ExerciseId = exToAdd.Id, AppUserId = userId };
                    context.SelectedExercises.Add(selected);
                }
            }
        }

        public async Task<IEnumerable<SelectedExercise>> GetAllSelectedExAsync(string userId)
        {
            return await context.SelectedExercises.Where(x => x.AppUserId == userId).Include(e => e.Exercise).Include(a => a.AppUser).ToListAsync();
        }

        public async Task RemoveSelectedEx(SelectedExercise selected)
        {
            context.SelectedExercises.Remove(selected);
            await context.SaveChangesAsync();
        }
    }
}
