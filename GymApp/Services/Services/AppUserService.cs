namespace GymApp.Services.Services
{
    public class AppUserService : IAppUserService
    {
        private readonly GymAppDbContext context;

        public AppUserService(GymAppDbContext context)
        {
            this.context = context;
        }
        public async Task<AppUser> GetLoggedInUser(string email)
        {
            return await context.AppUsers.FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
