
namespace GymApp.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public RegisterModel(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [BindProperty]
        public RegisterViewModel Registration { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            AppUser user = new() { Name = Registration.Name, BirthDay = Registration.BirthDay, Gender = Registration.Gender, GymName = Registration.GymName, GymCity = Registration.GymCity };
            IdentityResult result = await userManager.CreateAsync(user, Registration.Password);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "user");
                await signInManager.SignInAsync(user, isPersistent: true);
                return RedirectToPage("/Index");
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return Page();
            }
        }
    }
}
