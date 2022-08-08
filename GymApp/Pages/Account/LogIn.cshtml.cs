
namespace GymApp.Pages.Account
{
    public class LogInModel : PageModel
    {
        private readonly SignInManager<AppUser> signInManager;

        public LogInModel(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        [BindProperty]
        public LogInViewModel LoginViewModel { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(LoginViewModel.Email, LoginViewModel.Password, LoginViewModel.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                    return !String.IsNullOrEmpty(returnUrl) ? RedirectToPage(returnUrl) : RedirectToPage("/Index");

                ModelState.AddModelError(String.Empty, "Email or password are incorrect.");
            }

            return Page();
        }
    }
}