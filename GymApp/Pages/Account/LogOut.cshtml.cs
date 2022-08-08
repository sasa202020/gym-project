
namespace GymApp.Pages.Account
{
    public class LogOutModel : PageModel
    {
        private readonly SignInManager<AppUser> signInManager;


        public LogOutModel(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;

        }

        public async Task<IActionResult> OnGetAsync()
        {
            await signInManager.SignOutAsync();
            return RedirectToPage("/Index");
        }
    }
}
