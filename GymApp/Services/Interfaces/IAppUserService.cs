namespace GymApp.Services.Interfaces
{
    public interface IAppUserService
    {
        public Task<AppUser> GetLoggedInUser(string email);
    }
}
