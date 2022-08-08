namespace GymApp.Services.Interfaces
{
    public interface IExerciseService
    {
        public Task<IEnumerable<Exercise>> GetAllExercisesAsync();
        public Task CreateExerciseAsync(Exercise e);
        public Task RemoveExerciseAsync(int exId);
        public Task EditExerciseAsync(Exercise e);
        public Task<Exercise> GetExerciseByIdAsync(int exId);
    }
}
