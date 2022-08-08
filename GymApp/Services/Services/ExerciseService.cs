
namespace GymApp.Services.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly GymAppDbContext context;

        public ExerciseService(GymAppDbContext context)
        {
            this.context = context;
        }
        public async Task CreateExerciseAsync(Exercise e)
        {
            context.Exercises.Add(e);
            await context.SaveChangesAsync();
        }

        public async Task EditExerciseAsync(Exercise e)
        {
            Exercise ex = context.Exercises.FirstOrDefault(x => x.Id == e.Id);
            ex.Name = e.Name;
            ex.Description = e.Description;
            ex.PicturePath = e.PicturePath;
            ex.ExerciseType = e.ExerciseType;
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Exercise>> GetAllExercisesAsync()
        {
             return await context.Exercises.ToListAsync();
        }

        public async Task<Exercise> GetExerciseByIdAsync(int exId)
        {
            return await context.Exercises.FirstOrDefaultAsync(e => e.Id == exId);
        }

        public async Task RemoveExerciseAsync(int exId)
        {
            Exercise ex = await context.Exercises.FirstOrDefaultAsync(x => x.Id == exId);
            context.Exercises.Remove(ex);
            await context.SaveChangesAsync();
        }
    }
}
