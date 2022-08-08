namespace GymApp.Services.Interfaces
{
    public interface ISelectedExercisesService
    {
        public Task AddSelectExercisesAsync(IEnumerable<Exercise> exercises, string userId);
        public Task<IEnumerable<SelectedExercise>> GetAllSelectedExAsync(string userId);
        public Task RemoveSelectedEx(SelectedExercise selected);
    }
}
